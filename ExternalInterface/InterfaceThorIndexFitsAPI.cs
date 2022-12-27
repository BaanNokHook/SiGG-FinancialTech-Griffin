using GM.Model.Common;
using GM.Model.ExternalInterface.InterfaceThorIndex;
using System.Collections.Generic;
using System.Net.Http;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceReqThorIndexFitsAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceThorIndexFits";   

        public InterfaceThorIndexFitsAPI(HttpClient client) : base(client)    
        {
        }  

        public ResultWithModel<List<InterfaceReqThorIndexFitsModel>> ImportThorIndexFits(InterfaceReqThorIndexFitsModel model)   
        {
            return Post<List<InterfaceReqThorIndexFitsModel>>(_subUrl + "/ImportThorindexFits", model);   
        }  
    }  
}