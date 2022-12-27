using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{
    
    public class InterfaceMarketPriceTbmaFitsAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceMarketPriceTbmaFits";  

        public InterfaceMarketPriceTbmaFitsAPI(HttpClient client) : base(client)  
        {
        }  

        public ResultWithModel<list<InterfaceMarketPriceTbmaModel>> ImportMarketPriceTbmaFits(InterfaceMarketPriceTbmaModel model)  
        {
            return Post<List<InterfaceMarketPriceTbmaModel>>(_subUrl + "/ImportMarketPriceTbmaFits", model);  
        } 
    }
}