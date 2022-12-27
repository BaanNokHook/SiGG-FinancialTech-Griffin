using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{

    public class ConfigAPI : WebClient  
    {
      
         private static readonly string _subUrl = "Config";    

         public ConfigAPI(HttpClient client) : base(client)    
         {
         }  

         public ResultWithModel<List<ConfigModel>> GetConfigForDropdown(string key)   
         {
            return Get<List<ConfigModel>>(_subUrl + "/getConfigForDropdown?Key=" + key);   
         }

         public ResultWithModel<List<DDLItemModel>> GetReportID(String category, string itemcode)  
         {
            return Get<List<DDLItemModel>>(_subUrl + "/GetConfigReport?category=" + category + "&itemcode=" + itemcode);   
         }  

         public ResultWithModel<List<DDLItemModel>> GetObligateType(string obligatetype)  
         {
            return Get<List<DDLItemModel>>(_subUrl + "/GetObligateType?obligatetype=" + obligatetype);   
         }  

         public ResultWithModel<List<DDLItemModel>> GetPortForReportDDL(string portdesc)  
         {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLPortfolioForReport?portdesc=" + portdesc);    
         } 
    }
}