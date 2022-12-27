using System.Data;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class TransLeqAPI : WebClient
    {
        private static readonly string _subUrl = "TransLeq";

        public TransLeqAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<DataSet> GetTransLeqList(TransLeqModel model)
        {
            return Post<DataSet>(_subUrl + "/GetTransLeqList", model);
        }
    }
}
