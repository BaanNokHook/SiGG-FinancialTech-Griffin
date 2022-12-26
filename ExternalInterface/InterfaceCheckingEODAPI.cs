using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceCheckingEodAPI : WebClient  
    {
      private static readonly string _subUrl = "InterfaceCheckongEod";   

      public InterfaceCheckingEodAPI(HttpClient client) : base(client)   
      {
      }

      public ResultWithModel<List<InterfaceCheckingEodModel>> CheckingEodList(InterfaceCheckingEodModel model)
        {
            return Post<List<InterfaceCheckingEodModel>>(_subUrl + "/CheckingEodList", model);
        }

        public ResultWithModel<List<InterfaceCheckingEodModel>> UpdateCheckingEod(InterfaceCheckingEodModel model)
        {
            return Post<List<InterfaceCheckingEodModel>>(_subUrl + "/UpdateCheckingEod", model);
        }
    }
}