using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;

namespace GM.ClientAPI.Endpoint.Static
{
    public class RatingAPI : WebClient
    {
        private static readonly string _subUrl = "Rating";

        public RatingAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLLocalRating(string agencycode, string shortlongterm, string datatext)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLLocalRating?agencycode=" + agencycode + "&shortlongterm=" + shortlongterm + "&datatext=" + datatext);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLForeignRating(string agencycode, string shortlongterm, string datatext)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLForeignRating?agencycode=" + agencycode + "&shortlongterm=" + shortlongterm + "&datatext=" + datatext);
        }
    }
}
