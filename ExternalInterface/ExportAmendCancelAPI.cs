using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class ExportAmendCancelAPI : WebClient
    {
        private static readonly string _subUrl = "ExportAmendCancel";   

        public ExportAmendCancelAPI(HttpClient client) : base(clienet)   
        {
        }

        public ResultWithModel<List<ExportAmendCancelDailyMailModel>> ExportAmendCancelDailyMail(ExportAmendCancelDailyMailModel model)   
        {
            return Post<List<ExportAmendCancelDailyMailModel>>(_subUrl + "/ExportAmendCancelDailyMail", model);   
        }

        public ResultWithModel<List<ExportAmendCancelMonthlyMailModel>> ExportAmendCancelMonthlyMail(ExportAmendCancelMonthlyMailModel model)    
        {
            return Post<List<ExportAmendCancelMonthlyMail>>(_subUrl + "/ExportAmendCancelMonthlyMail", model);   
        }
    }
}