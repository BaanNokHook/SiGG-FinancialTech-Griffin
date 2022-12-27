using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{
    public class ProvinceAPI : WebClient
    {
        private static readonly string _subUrl = "Province";

        public ProvinceAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLProvince(string province_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetProvice?province_name=" + province_name);
        }
    }
}