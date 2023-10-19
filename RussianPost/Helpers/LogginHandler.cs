﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.RussianPost.Helpers
{
    public class LoggingHandler : DelegatingHandler
    {
        public LoggingHandler() : this(new HttpClientHandler()) { }
        public LoggingHandler(HttpMessageHandler innerHandler) : base(innerHandler) { }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Request:");
            Console.WriteLine(request.ToString());
            if (request.Content != null)
            {
                Console.WriteLine(await request.Content.ReadAsStringAsync());
            }
            Console.WriteLine();

            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

            Console.WriteLine("Response:");
            Console.WriteLine(response.ToString());
            if (response.Content != null)
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync(cancellationToken));
            }
            Console.WriteLine();

            return response;
        }
    }
}
