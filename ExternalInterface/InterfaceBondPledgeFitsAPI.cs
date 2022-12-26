using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{
    public class InterfaceBondPledgeFitsAPI : WebClient
    {
        private static readonly string _subUrl = "InterfaceBondPledgeFits";

        public InterfaceBondPledgeFitsAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<InterfaceBondPledgeFitsModel>> ExportBondPledgeFits(InterfaceBondPledgeFitsModel model)
        {
            return Post<List<InterfaceBondPledgeFitsModel>>(_subUrl + "/ExportBondPledgeFits", model);
        }
    }
}