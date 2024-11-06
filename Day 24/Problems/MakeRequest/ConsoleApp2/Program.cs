using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void MakeRequest()
        {
            string targetUrl = "https://jsonplaceholder.typicode.com/users";
            var client = new HttpClient();
            var response = client.GetAsync(targetUrl).Result;
            response.EnsureSuccessStatusCode();

            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseContent);
        }

        static async Task MakeRequestAsync(int id)
        {
            string targetUrl = $"https://jsonplaceholder.typicode.com/posts/{id}";
            var client = new HttpClient();
            var response = await client.GetAsync(targetUrl);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            await Task.Delay(1000);
            Console.WriteLine(responseContent);
        }
        //static void Main(string[] args)
        //{
        //    MakeRequest();
        //}
        public static async Task Main()
        {
            for (int i = 1; i < 10; i++)
            {
                await MakeRequestAsync(i);
            }
        }
    }
}
