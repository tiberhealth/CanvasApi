using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CanvasApi.Client
{
    internal class QueryParameter
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class PagingOptions
    {
        public int PageSize { get; set; }

        public PagingOptions(): this(50)
        {}

        public PagingOptions(int pageSize)
        {
            this.PageSize = pageSize;
        }

        internal string AddPagingUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return url;
            var queryParameters = this.GetQueryParameters(url, out var baseUrl).ToList();

            queryParameters.AddOrUpdateParameter("per_page", this.PageSize.ToString());

            return $"{baseUrl}?{string.Join('&', queryParameters.Select(item => item.ToQueryParam()))}";
        }

        private IEnumerable<QueryParameter> GetQueryParameters(string url, out string baseUrl)
        {
            var parts = url.Split('?');
            baseUrl = parts[0];

            if (parts.Length < 2) return Array.Empty<QueryParameter>();
            return parts[1].Split('&').Select(this.GetQueryParameter).ToArray();
        }

        private QueryParameter GetQueryParameter(string queryParameter)
        {
            var qpParts = queryParameter.Split('=');
            return new QueryParameter
            {
                Key = qpParts[0],
                Value = qpParts.Length == 2 ? qpParts[1] : string.Empty
            };
        }
    }

    internal static class QueryParameterExtensions
    {
        public static bool TryGet (
            this List<QueryParameter> queryParameters,
            string parameter,
            out QueryParameter value)
        {
            value = queryParameters.Where(item => item.Key.Equals(parameter, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            return value != null;
        }

        public static void AddOrUpdateParameter(this List<QueryParameter> queryParameters, string parameter, string value)
        {
            if (!queryParameters.TryGet(parameter, out var qp))
            {
                qp = new QueryParameter { Key = parameter };
                queryParameters.Add(qp);
            }

            qp.Value = value;
        }

        public static string ToQueryParam(this QueryParameter queryParameter)  =>
            ($"{queryParameter.Key}" + (!string.IsNullOrWhiteSpace(queryParameter.Value) ?  $"={queryParameter.Value}" : string.Empty)).Trim();
    }
}
