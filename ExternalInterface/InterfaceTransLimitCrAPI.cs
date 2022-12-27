using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

   public class InterfaceTransLimitCrAPI : WebClient  
   {
      private static readonly string _subUrl = "InterfaceTransLimitCr";   

      public InterfaceTransLimitCrAPI(HttpClient client) : base(client)   
      {
      }

      public ResultWithModel<list<InterfaceTransLimitCrModel>> ExportTransLimitCr(InterfaceTransLimitCrModel model)
      {
            return Post<List<InterfaceTransLimitCrModel>>(_subUrl + "/ExportTransLimitCr", model);  
      }  

      public ResultWithModel<List<InterfaceTransLimitCrModel>> ExportTransLimitCrEod(InterfaceTransLimitCrModel model)   
      {
            return Post<List<InterfaceTransLimitCrModel>>(_subUrl + "/ExportTransLimitCrEod", model);  
      }  
   } 
}  