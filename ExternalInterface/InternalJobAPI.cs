using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InternalJobAPI : WebClient
    {
        private static readonly string _subUrl = "InternalJob";   

        public InternalJobAPI(HttpClient client) : base(client)   
        {
        }  

        public ResultWithModel<List<InternalJobModel>> InternalBatchJobEod(InternalJobModel model)   
        {
            return Post<List<InternalJobModel>>(_subUrl + "/InternalBatchJobEod", model);
        }

        public ResultWithModel<List<InternalJobModel>> InternalBatchJobEndOfDay(InternalJobModel model)  
        {
            return Post<List<InternalJobModel>>(_subUrl + "/InternalBatchJobEndOfDay", model);  
        }
    }
}