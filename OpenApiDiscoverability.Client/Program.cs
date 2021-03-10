using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenApiDiscoverability.Client
{
    /// <summary>
    /// https://devblogs.microsoft.com/aspnet/generating-http-api-clients-using-visual-studio-connected-services/
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var httpClient = new HttpClient();

            var apiClient = new WebapiClient("http://localhost:41676", httpClient);

            var shops = await apiClient.GetShopsAsync();

            foreach (var shop in shops)
            {
                Console.WriteLine(shop);
            }

            Console.Read();
        }
    }
}
