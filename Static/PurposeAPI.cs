using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class PurposeAPI : WebClient
    {
        private static readonly string _subUrl = "Purpose";

        public PurposeAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<PurposeModel>> Create(PurposeModel model)
        {
            return Post<List<PurposeModel>>(_subUrl + "/Create", model);
        }

        public ResultWithModel<List<PurposeModel>> GetEdit(PurposeModel model)
        {
            return Post<List<PurposeModel>>(_subUrl + "/GetEdit", model);
        }

        public ResultWithModel<List<PurposeModel>> Update(PurposeModel model)
        {
            return Post<List<PurposeModel>>(_subUrl + "/Update", model);
        }

        public ResultWithModel<List<PurposeModel>> Delete(PurposeModel model)
        {
            return Post<List<PurposeModel>>(_subUrl + "/Delete", model);
        }

        public ResultWithModel<List<PurposeModel>> GetPurposeList(PurposeModel model)
        {
            return Post<List<PurposeModel>>(_subUrl + "/GetPurposeList", model);
        }
    }
}