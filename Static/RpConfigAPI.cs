using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class RpConfigAPI : WebClient
    {
        private static readonly string _subUrl = "Config";

        public RpConfigAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<RpConfigModel>> GetRpConfig(string category, string itemCode)
        {
            return Get<List<RpConfigModel>>(_subUrl + "/GetRpConfig?Category=" + category + "&ItemCode=" + itemCode);
        }
    }
}