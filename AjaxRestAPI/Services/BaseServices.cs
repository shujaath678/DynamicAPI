using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AjaxRestAPI.Controllers;
using System.Threading;
using System.Collections.Generic;
using AjaxRestAPI.Models;

namespace AjaxRestAPI.Services
{
    public interface IBaseServices
    {
        Task<List<string>> BaseServiceMethod();
    }


    public class BaseServices : IBaseServices
    {
        public async Task<List<string>> BaseServiceMethod()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5001/CallBack/"); 

                var loadPosts = new List<Task<string>>();
                HttpResponseMessage firstResponse = client.GetAsync("firstCall").Result;
                var firstContent = firstResponse.Content.ReadAsStringAsync();
                loadPosts.Add(firstContent);

                HttpResponseMessage secondResponse = client.GetAsync("secondCall").Result;
                var secondContent = secondResponse.Content.ReadAsStringAsync();
                loadPosts.Add(secondContent);

                await Task.WhenAll(loadPosts);
                List<string> res = new List<string>();

                foreach(var post in loadPosts)
                {
                    res.Add(post.Result);
                }
                return res;
            }
        }
    }
}
