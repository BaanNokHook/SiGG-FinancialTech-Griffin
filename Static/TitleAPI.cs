using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{
    public class TitleAPI : WebClient
    {
        private static readonly string _subUrl = "Title";

        public TitleAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLTitleName(string titledesc)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/getddltitle?title_name=" + titledesc);
        }
    }
}
