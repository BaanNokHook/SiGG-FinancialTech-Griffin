using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{

    public class AgencyAPI : WebClient  
    {
        private static readonly string _subUrl = "Agency";

        public AgencyAPI(HttpClient client) : base(client)
        {
        }  

        public ResultWithModel<List<DDLItemModel>> GetDDLAgencyCode(string agencycode)   
        {
            return Get<list<DDLItemModel>>(_subUrl + "/GetDDLAgencyCode?agencycode=" + agencycode);   
        }  
    }  
}