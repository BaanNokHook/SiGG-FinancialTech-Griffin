using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface.ExchRateSummit;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceExchangeRateSummitAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceExchangeRateSummit";  

        public InterfaceExchangeRateSummit(HttpClient client) : base(client)  
        {
        }

        public ResultWithModel<List<InterfaceReqExchRateHeaderSummitModel>> ImportExchangeRateSSMD(InterfaceExchangeRateSummitModel model)  
        {
            return Post<List<InterfaceReqExchRateHeaderSummitModel>>(_subUrl + "/ImportantExchangeRateSSMD", model); 
        }
    }
}