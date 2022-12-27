using System.Data;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class DwhAPI : WebClient
    {
        private static readonly string _subUrl = "DWH";

        public DwhAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<DataSet> GetDWHList(DWHModel model)
        {
            return Post<DataSet>(_subUrl + "/GetDWHList", model);
        }

        public ResultWithModel<DataSet> GetDDLFileType(DWHModel model)
        {
            return Post<DataSet>(_subUrl + "/GetDDLFileType", model);
        }
    }
}