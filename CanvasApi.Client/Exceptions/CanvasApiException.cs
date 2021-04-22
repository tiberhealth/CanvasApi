using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasApi.Client.Exceptions
{
    public class CanvasApiException : Exception
    {
        public HttpResponseMessage Response { get; }
        public HttpStatusCode? StatusCode => this.Response?.StatusCode;
        public bool? IsSuccessful => this.Response.IsSuccessStatusCode;

        public JObject ApiResultObject { get; private set; }
        public string ResultMessage { get; private set; }

        internal CanvasApiException(HttpResponseMessage response, string message = null, Exception innterException = null) : base(message, innterException)
        {
            this.Response = response;
            this.ParseApiResult().Wait(); 
        }

        private async Task ParseApiResult()
        {
            var msg = await this.Response.Content.ReadAsStringAsync();
            try
            {
                this.ApiResultObject = JObject.Parse(msg);
            }
            catch (JsonReaderException)
            {
                this.ApiResultObject = null;
                this.ResultMessage = msg;
            }
            catch (Exception ex)
            {
                this.ResultMessage = ex.Message;
            }
        }
    }
}
