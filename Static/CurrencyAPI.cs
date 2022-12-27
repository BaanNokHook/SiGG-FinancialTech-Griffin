using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class CurrencyAPI : WebClient
    {
        private static readonly string _subUrl = "Currency";

        public CurrencyAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCurrency(string cur)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetCurrency?cur=" + cur);
        }

        public ResultWithModel<List<CurrencyModel>> GetCurrencyList(CurrencyModel model)
        {
            return Post<List<CurrencyModel>>(_subUrl + "/GetCurrencyList", model);
        }

        public ResultWithModel<List<CurrencyModel>> CreateCurrency(CurrencyModel model)
        {
            return Post<List<CurrencyModel>>(_subUrl + "/CreateCurrency", model);
        }

        public ResultWithModel<List<CurrencyModel>> GetCurrencyEdit(CurrencyModel model)
        {
            return Post<List<CurrencyModel>>(_subUrl + "/GetCurrencyEdit", model);
        }

        public ResultWithModel<List<CurrencyModel>> UpdateCurrency(CurrencyModel model)
        {
            return Post<List<CurrencyModel>>(_subUrl + "/UpdateCurrency", model);
        }

        public ResultWithModel<List<CurrencyModel>> DeleteCurrency(CurrencyModel model)
        {
            return Post<List<CurrencyModel>>(_subUrl + "/DeleteCurrency", model);
        }
    }
}
