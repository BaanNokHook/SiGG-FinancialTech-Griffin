using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{
    public class SubDistrictAPI : WebClient
    {
        private static readonly string _subUrl = "SubDistrict";

        public SubDistrictAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLSubDistrict(string district_id, string subdistrict_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetSubDistrictByDistrictIdAndSubDistrictName?district_id=" + district_id + "&subdistrict_name=" + subdistrict_name);
        }
    }
}