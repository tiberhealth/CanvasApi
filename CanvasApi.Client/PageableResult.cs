using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace CanvasApi.Client
{
    internal class PageableResult<TResult>: IEnumerable<TResult>
    {
        private readonly TResult[] _InitialBuffer;
        private readonly CanvasApiClient _ApiClient;
        private readonly PageLinks _initalPageLinks;

        internal PageableResult(IEnumerable<TResult> initialBuffer, CanvasApiClient apiClient, PageLinks pageLinks)
        {
            this._InitialBuffer = initialBuffer?.ToArray() ?? Array.Empty<TResult>();
            this._initalPageLinks = pageLinks ?? throw new ArgumentNullException(nameof(pageLinks), "Paging details not supplied.");
            this._ApiClient = apiClient;
        }

        public IEnumerator<TResult> GetEnumerator() => new PageableResultsEnumerator<TResult>(this._InitialBuffer, this._initalPageLinks, this._ApiClient);

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }


    internal class PageableResultsEnumerator<TResult> : IEnumerator<TResult>
    {
        private TResult[] Buffer { get; set; }
        private PageLinks Links { get; set; }
        private CanvasApiClient ApiClient { get; }

        int bufferIdx = -1; 

        internal PageableResultsEnumerator(TResult[] buffer, PageLinks links, CanvasApiClient apiClient)
        {
            this.Buffer = buffer ?? Array.Empty<TResult>();

            this.Links = links;
            this.ApiClient = apiClient;

            bufferIdx = -1;
        }

        public TResult Current => bufferIdx >= 0 && bufferIdx < this.Buffer.Length ? this.Buffer[this.bufferIdx] : default(TResult);
        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            // Nothing to dispose
        }

        public bool MoveNext() => ++bufferIdx < this.Buffer.Length ? true : this.MoveNextPage();

        public void Reset() =>this.GetPage(this.Links.First ?? this.Links.OriginalUrl, true);
        private bool MoveNextPage() => this.GetPage(this.Links.Next);

        private bool GetPage(string url, bool isReset = false)
        {
            if (string.IsNullOrWhiteSpace(url)) return false;

            var newPageLinks = new PageLinks(this.Links.OriginalUrl);
            var apiCall = this.ApiClient.ApiOperation<IEnumerable<TResult>, object>(Enums.ApiVerb.Get, this.Links.Next, null, newPageLinks);
            apiCall.Wait();

            this.Buffer = apiCall.Result.ToArray();

            this.Links = newPageLinks;
            bufferIdx = -1;

            return isReset ? true : this.MoveNext();
        }
    }
}
