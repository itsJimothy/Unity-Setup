using System;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace Jimothy.Setup
{
    internal static class Imports
    {
        public static async Task<string> FetchGist(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to fetch gist: " + e.Message);
            }

            var content = await response.Content.ReadAsStringAsync();

            return content;
        }
    }
}