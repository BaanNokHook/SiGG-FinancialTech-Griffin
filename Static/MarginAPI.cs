using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{
    public class MarginAPI : WebClient
    {
        private static readonly string _subUrl = "Margin";

        public MarginAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCounterPartyMarginType(string margin_type_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLMarginType?margin_type_name=" + margin_type_name);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCounterPartyMarginInType(string margin_in_type_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLMarginInType?margin_in_type_name=" + margin_in_type_name);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCounterPartyMarginInTerm(string margin_in_term_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLMarginInTerm?margin_in_term_name=" + margin_in_term_name);
        }
    }
}