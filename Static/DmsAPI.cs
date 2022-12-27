using System.Data;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class DmsAPI : WebClient
    {
        private static readonly string _subUrl = "DMS";

        public DmsAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<DataSet> GetDMSList(DMSModel model)
        {
            return Post<DataSet>(_subUrl + "/GetDMSList", model);
        }
    }
}
