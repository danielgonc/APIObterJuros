using ApiObterJuros;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestProject.API
{
    public class JurosAPITest
    {
        private readonly HttpClient _client;

        public JurosAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task GetTaxaJurosTest(string method)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), "api/Juros/taxaJuros");

            var response = await _client.SendAsync(request);

            // Assert 
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
