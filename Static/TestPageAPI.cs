using System.Data;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class TestPageAPI : WebClient
    {
        private static readonly string _subUrl = "TestPage";

        public TestPageAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<DataSet> GetTestPageList(TestPageModel model)
        {
            return Post<DataSet>(_subUrl + "/GetTestPageList", model);
        }
    }
}