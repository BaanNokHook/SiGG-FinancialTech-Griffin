using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{
    public class InterfaceFxAPI : WebClient
    {

      private static readonly string _subUrl = "InterfaceFx"

      public InterfaceFxAPI(HttpClient client) : base(client)  
      {
      } 

      public ResultWithModel<List<InterfaceFxReconcileSftpModel>> ExportInterfaceFxReconcile(InterfaceFxReconcileSftpModel model)   
      {
            return Post<List<InterfaceFxReconcileSftpModel>>(_subUrl + "/ExternalInterfaceFxReconcile", model);  
      }
   }
}