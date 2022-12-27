using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class CustodianAPI : WebClient
    {
        private static readonly string _subUrl = "Custodian";

        public CustodianAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCustodian(string custodian_code)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLCustodian?custodian_code=" + custodian_code);
        }

        public ResultWithModel<List<CustodianModel>> Create(CustodianModel model)
        {
            return Post<List<CustodianModel>>(_subUrl + "/Create", model);
        }

        public ResultWithModel<List<CustodianModel>> GetEdit(CustodianModel model)
        {
            return Post<List<CustodianModel>>(_subUrl + "/GetEdit", model);
        }

        public ResultWithModel<List<CustodianModel>> Update(CustodianModel model)
        {
            return Post<List<CustodianModel>>(_subUrl + "/Update", model);
        }

        public ResultWithModel<List<CustodianModel>> Delete(CustodianModel model)
        {
            return Post<List<CustodianModel>>(_subUrl + "/Delete", model);
        }

        public ResultWithModel<List<CustodianModel>> GetList(CustodianModel model)
        {
            return Post<List<CustodianModel>>(_subUrl + "/GetCustodianList", model);
        }
    }
}