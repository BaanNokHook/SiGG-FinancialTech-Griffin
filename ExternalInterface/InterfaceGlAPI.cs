using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceGlAPI : WebClient   
    {
       private static readonly string _subUrl = "interfaceGl";   

       public InterfaceGlAPI(HttpClient client) : base(client)
       {
       }

       public ResultWithModel<List<InterfaceGlSftpModel>> ExportInterfaceGl(InterfaceGlSftpModel model)
       {
            return Post<List<InterfaceGlSftpModel>>(_subUrl + "/ExportInterfaceGl", model);
       }
    }
}