using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{
    public class KtbIsicAPI :  WebClient
    {
        private static readonly string _subUrl = "KtbIsic";

        public KtbIsicAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLKTB_ISIC(string ktb_isic_desc)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLKtbIsic?ktb_isic_desc=" + ktb_isic_desc);
        }
    }
}