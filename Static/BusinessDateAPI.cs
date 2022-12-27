using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
 
    public class BusinessDateAPI : WebClient  
    {
        private static readonly string _subUrl = "BusinessDate";  

        public BusinessDateAPI(HttpClient client) : base(client)  
        {
        }  

        public ResultWithModel<List<BusinessDateModel>> GetBusinessDateList(BusinessDateModel model)   
        {
            return Post<List<BusinessDateModel>>(_subUrl + "/GetBusinessDateList", model);   
        }  

        public ResultWithModel<List<RpDateModel>> GetBusinessDateOrSystemDate(RpDateModel model)  
        {
            return Post<list<RpDateModel>>(_subUrl + "/GetBusinessDateOrSystemDate", model);   
        }  
    }  
}