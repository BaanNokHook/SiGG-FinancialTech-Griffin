using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.CounterParty
{

    public class CounterPartyAPI : WebClient 
    {
        private static readonly string _subUrl = "CounterParty";  

        public CounterPartyAPI(HttpClient client) : base(client)   
        {
        }  

        public ResultWithModel<List<DDLItemModel>> GetDDLCounterPartyType(string counter_party_type_desc)  
        {
            return Get<List<GetDDLItemModel>>(_subUrl + "/GetDDLCounterPartyType?counter_party_type_desc=" + counter_party_type_desc);  
        }       
    }
}