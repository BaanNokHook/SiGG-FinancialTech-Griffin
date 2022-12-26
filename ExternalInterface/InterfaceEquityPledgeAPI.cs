using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceEquityPledgeAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceEquilyPledge";  

        public InterfaceEquityPledgeAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<InterfaceEquityPledgeModel>> InterfaceEquityPledge(InterfaceEquityPledgeModel model)
        {
            return Post<List<InterfaceEquityPledgeModel>>(_subUrl + "/InterfaceEquityPledge", model);
        }

    }
}