using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Todoist.NET.Services
{
    public class TodoistConfiguration
    {
        protected string BaseUrl { get; } = "https://api.todoist.com/rest/v2/";
        public HttpClient HttpClient { get; }
        public string ApiToken { get; }

        public TodoistConfiguration(HttpClient httpClient, string token)
        {
            HttpClient = httpClient;
            HttpClient.BaseAddress = new Uri(BaseUrl);
            ApiToken = token;
            HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", ApiToken);
        }
    }
}
