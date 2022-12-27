using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class TestConnectAPI : WebClient
    {
        private static readonly string _subUrl = "TestConnect";

        public TestConnectAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<TestConnectModel>> GetTestDatabaseInfoList(TestConnectModel model)
        {
            return Post<List<TestConnectModel>>(_subUrl + "/GetTestDatabaseInfoList", model);
        }

        public ResultWithModel<List<RpConfigModel>> GetExternalServiceList(TestConnectModel model)
        {
            return Post<List<RpConfigModel>>(_subUrl + "/GetExternalServiceList", model);
        }
    }
}
