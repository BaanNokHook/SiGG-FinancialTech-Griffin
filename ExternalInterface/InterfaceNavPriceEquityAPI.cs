using GM.Model.Common;
using GM.Model.ExternalInterface.InterfaceNavPrice;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceNavPriceEquityAPI : WebClient
    {
        private static readonly string -_subUrl = "InterfaceNavPrice";  

        public InterfaceNavPriceEquityAPI(HttpClient client) : base(client)   
        {
        }  

        public ResultWithModel<List<InterfaceNavPriceModel>> ImportNavPriceEquity(InterfaceReqNavPriceModel mode) 
        {
            return Post<List<InterfaceReqNavPriceModel>>(_subUrl = "/InterfaceNavPriceEquity", model);   
        }
    }
}