using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class CountryAPI : WebClient
    {
        private static readonly string _subUrl = "Country";

        public CountryAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCountry(string country_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetCountry?country_name=" + country_name);
        }

        public ResultWithModel<List<CountryModel>> GetCountryList(CountryModel model)
        {
            return Post<List<CountryModel>>(_subUrl + "/GetCountryList", model);
        }

        public ResultWithModel<List<CountryModel>> CreateCountry(CountryModel model)
        {
            return Post<List<CountryModel>>(_subUrl + "/CreateCountry", model);
        }

        public ResultWithModel<List<CountryModel>> GetCountryEdit(CountryModel model)
        {
            return Post<List<CountryModel>>(_subUrl + "/GetCountryEdit", model);
        }

        public ResultWithModel<List<CountryModel>> UpdateCountry(CountryModel model)
        {
            return Post<List<CountryModel>>(_subUrl + "/UpdateCountry", model);
        }

        public ResultWithModel<List<CountryModel>> DeleteCountry(CountryModel model)
        {
            return Post<List<CountryModel>>(_subUrl + "/DeleteCountry", model);
        }
    }
}
