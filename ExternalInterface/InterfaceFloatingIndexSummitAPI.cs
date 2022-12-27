using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface.FloatingIndexSummit;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{
  
     public static InterfaceFloatingIndexSummitAPI : WebClient  
     {
      
        private static readonly string _subUrl = "InterfaceFloatingIndexSummit";  

        public InterfaceFloatingIndexSummitAPI(HttpClient client) : base(client)
        {   
        } 

        public ResultWithModel<List<InterfaceFloatingIndexSummitModel>> ImportFloatingIndexSSMD(InterfaceFloatingIndexSummitModel model)   
        {
            return Post<List<InterfaceFloatingIndexSummitModel>>(_subUrl + "/ImportFloatingindexSSMD", model);   
        } 
     }
}