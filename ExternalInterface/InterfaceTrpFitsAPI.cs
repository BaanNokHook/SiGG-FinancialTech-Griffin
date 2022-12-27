using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{
   
    public class InterfaceTrpFitsAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceTrpFITS";      

        public InterfaceTrpFitsAPI(HttpClient client) : base(client)   
        {  
        }     

        public ResultWithModel<List<InterfaceTrpFitsSftpModel>> ExportInterfaceTrpFits(InterfaceTrpFitsSftpModel model)     
        {
            return Post<List<InterfaceTrpFitsSftpModel>>(_subUrl + "/ExportInterfaceTrpFits", model);   
        } 
      } 
}