using System;
using System.Net.Http;

namespace JobSearch.App.Services
{
    public abstract class Service
    {
        protected HttpClient _client;
        protected readonly string _baseApiUrl = "";

        public Service()
        {
            _client = new HttpClient();
        }
    }
}
