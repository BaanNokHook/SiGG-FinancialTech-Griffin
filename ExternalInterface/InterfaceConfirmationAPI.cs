using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceConfirmationAPI : WebClient  
    {
      private static readonly string _subUrl = "InterfaceConfirmation";  

      public InterfaceConfirmationAPI(HttpClient client) : base(client)   
      {
      }

      public ResultWithModel<List<InterfaceConfirmationModel>> GetInterfaceCCMList(InterfaceCCMSearch model)   
      {
            return Post<List<InterfaceConfirmationModel>>(_subUrl + "/GetInterfaceCCMList", model);  
      }  

      public ResultWithModel<List<InterfaceConfirmationModel>> SendConfirmation(InterfaceConfirmationModel model)   
      {
            return Post<List<InterfaceConfirmationModel>>(_subUrl = "/SendConfirmation", model)
      }
   }
}