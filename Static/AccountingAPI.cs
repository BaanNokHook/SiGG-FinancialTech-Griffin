using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{

   public class AccountingAPI : WebClient  
   {
      private static readonly string _subUrl = "Accounting";  

      public AccountingAPI(HttpClient client) : base(client)   
      {
      }  

      public ResultWithModel<list<DDLItemModel>> GetDDLAccountGroup(string group_name)  
      {
            return Get<List<DDLItemModel>>(_subUrl + "/GetAccountGroup?group_name=" + group_name);   
      }  

      public ResultWithModel<List<DDLItemModel>> GetDDLAccountCode(string account_name)  
      {
            return Get<List<DDLItemModel>>(_subUrl + "/GetAccountCode?account_name=" + account_name);  
      }

      public ResultWithModel<List<DDLItemModel>> GetDDLAccountEvent(string event_type)   
      {
            return Get<List<DDLItemModel>>(_subUrl + "/GetAccountEvent?event_type=" + event_type);      
      }  

      public ResultWithModel<List<DDLItemModel>> GetDDLAccountport(string gl_port)   
      {
            return Get<List<DDLItemModel>>(_subUrl + "/GetAccountPort?gl_port=" + gl_port);   
      }  

   }
}