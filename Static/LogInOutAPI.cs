using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class LogInOutAPI : WebClient
    {
        private static readonly string _subUrl = "LogInOut";

        public LogInOutAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<LogInOutModel>> GetLogInOutList(LogInOutModel model)
        {
            return Post<List<LogInOutModel>>(_subUrl + "/GetLogInOutList", model);
        }
    }
}