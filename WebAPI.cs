using System.Net.Http;
using GM.ClientAPI.Endpoint;

namespace GM.ClientAPI
{
    public class WebAPI
    {
        public StaticEndpoint StaticAPI { get; }
        public CounterPartyEndpoint CounterPartyAPI { get; }
        public ExternalInterfaceEndpoint ExternalInterfaceAPI { get; }
        public WebAPI(IHttpClientFactory httpClientFactory)
        {
            CounterPartyAPI = new CounterPartyEndpoint(httpClientFactory);
            StaticAPI = new StaticEndpoint(httpClientFactory);
            ExternalInterfaceAPI = new ExternalInterfaceEndpoint(httpClientFactory);
        }
    }
}