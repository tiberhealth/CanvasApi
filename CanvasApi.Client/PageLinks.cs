using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace CanvasApi.Client
{
    internal class PageLinks
    {
        private IEnumerable<string> Links { get; set; }

        public string OriginalUrl { get; }
        public string Current => this.GetUrl("current");
        public string Next => this.GetUrl("next");
        public string Previous => this.GetUrl("previous");
        public string Last => this.GetUrl("last");
        public string First => this.GetUrl("first");

        public int CurrentPage => this.GetPageNumber(this.Current);
        public int NextPage => this.GetPageNumber(this.Next);
        public int PreviousPage => this.GetPageNumber(this.Previous);
        public int LastPage => this.GetPageNumber(this.Last);

        public PageLinks(string originalUrl) => this.OriginalUrl = originalUrl;

        internal void SetHeaders(HttpResponseHeaders headers)
        {
            this.Links =
                headers
                .Where(item => item.Key == "Link")
                .SelectMany(item => item.Value as string[])
                .Where(item => item != null)
                .SelectMany(item => item.Split(','))
                .ToArray();
        }

        internal int GetPageNumber(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return -1;

            var parameters = url.Split('?');
            if (parameters.Length <= 1) return -1;

            var pageParameter =
                parameters[1]
                .Split('&')
                .Where(item => item.StartsWith("page=", StringComparison.OrdinalIgnoreCase))
                .Select(item => item.Split('=')[1].Trim())
                .FirstOrDefault();

            return int.TryParse(pageParameter, out var page) ? page : -1;
        }

        private string GetUrl(string rel)
        {
            var link = this.Links.Where(item => item.Contains($"rel=\"{rel}\"", StringComparison.OrdinalIgnoreCase)).FirstOrDefault(); ;

            if (link == null) return null;
            var parts = link.Split(';');

            if (parts.Length == 2) return parts[0].Trim().TrimStart('<').TrimEnd('>');
            if (parts.Length == 0) return string.Empty;

            throw new Exception($"Inavlid link format. rel={rel}; link={link}");
        }
    }
}
