using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

   public class InterfaceCounterRateExRateAPI : WebClient  
   {
      private static readonly string _subUrl = "InterfaceCounterRateExRate";    

      public InterfaceCounterRateExRateAPI(HttpClient clident) : base(client)  
      {
      }

      public ResultWithModel<List<InterfaceCounterRateExRateModel>> ImportCounterRateExRate(InterfaceCounterRateExRateModel model)  
      {
            return Post<List<InterfaceCounterRateExRateModel>>(_subUrl + "/ImportCounterRateExRate", model);   
      
      }
   }
}