using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceMidValuationExRateAPI : WebClient  
    {
      private static readonly string _subUrl = "InterfaceMidValuationRateExRate"  

      public InterfaceMidValuationExRateAPI(HttpClient client) : base(client)
      {
      }  

      public ResultWithModel<List<InterfaceMidValuationExRateAPImodel>> ImportMidValuationExRate(InterfaceMidValuationExRateAPImodel model)   
      {
            return Post<List<InterfaceMidValuationRateExRateModel>>(_subUrl + "/ImportMidValuationExRate", model);   
      }
    }
}