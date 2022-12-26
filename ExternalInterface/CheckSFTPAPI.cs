using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class CheckSFTPAPI : WebClient
    {
        private static readonly string _subUrl = "ChecksSFTP";  

        public CheckSFTPAPI(HttpClient client) : base(client)  
        {
        }

        public ResultWithModel<object> ConnectionOpen(List<RpConfigModel> model)  
        {
            return Post<object>(_subUrl + "/ConnectionOpen", model);   
        }
    }
}