using System.Net.Http;
using GM.ClientAPI.Endpoint.CounterParty;

namespace GM.ClientAPI.Endpoint
{
    public class CounterPartyEndpoint
    {
        public CounterPartyAPI CounterParty { get; }

        public CounterPartyEndpoint(IHttpClientFactory httpClientFactory)
        {
            var client = httpClientFactory.CreateClient("CounterPartyEndpoint");
            CounterParty = new CounterPartyAPI(client);
        }
    }
}
