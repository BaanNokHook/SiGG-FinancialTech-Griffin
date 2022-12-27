using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceNesAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceNES";  

        public InterfaceNESAPI(HttpClient client) : base(client)   
        {
        } 

        public ResultWithModel<List<InterfaceNesSftpModel>> ExportInterfaceFNes(InterfaceNesSftpModel model)   
        {
            return Post<List<InterfaceNesSftpModel>>(_subUrl + "/ExportInterfaceNES", model);   
        }
    }
}