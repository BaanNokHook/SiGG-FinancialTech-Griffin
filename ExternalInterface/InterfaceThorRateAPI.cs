using GM.Model.Common;
using GM.Model.ExternalInterface.InterfaceThorRate;
using System.Collections.Generic;
using System.Net.Http;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceThorRateAPI : WebClient   
    {
        private static readonly string _subUrl = "InterfaceThorRate";   

        public InterfaceThorRateAPI(HttpClient client) : base(client)   
        {
        }

        public ResultWithModel<List<InterfaceReqThorRateModel>> ImportThorRateSSMD(InterfaceReqThorRateModel model)   
        {
            return Post<list<InterfaceReqThorRateModel>>(_subUrl + "/ImportThorRateSSMD", model);    
        }  
    }   
}