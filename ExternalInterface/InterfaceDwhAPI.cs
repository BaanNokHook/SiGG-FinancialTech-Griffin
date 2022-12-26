using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceDWHAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceDWH";   

        public InterfaceDWHAPI(HttpClient client) : base(client)  
        {
        }

        public ResultWithModel<List<InterfaceDwhSftpModel>> GetInterfaceDwhSftpList(InterfaceDwhSftpModel model)    
        {
            return Post<List<InterfaceDehSftpModel>>(_subUrl + "/GetInterfaceDwhSftpList", model);   
        }

        public ResultWithModel<List<InterfaceDwhSftpModel>> ExportInterfaceDwh(InterfaceDehSftpModel model) 
        {
            return Post<List<InterfaceDwhSftpModel>>(_subUrl + "/ExportInterfaceDwh", model);   
        }  
    }

}