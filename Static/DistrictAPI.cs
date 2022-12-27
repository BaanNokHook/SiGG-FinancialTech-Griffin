using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{
    public class DistrictAPI : WebClient
    {
        private static readonly string _subUrl = "District";

        public DistrictAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLDistrict(string provice_id, string district_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDistrictByProvinceAndDistrictDesc?provice_id=" + provice_id + "&district_name=" + district_name);
        }
    }
}