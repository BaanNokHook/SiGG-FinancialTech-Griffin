using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class InitialMarginAPI : WebClient
    {
        private static readonly string _subUrl = "InitialMargin";

        public InitialMarginAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDlSecurityType(string instrumentTypeName)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDlSecurityType?InstrumentTypeName=" + instrumentTypeName);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDlCouponType(string couponType)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDlCouponType?CouponType=" + couponType);
        }

        public ResultWithModel<List<InitialMarginModel>> GetInitialMarginList(InitialMarginModel model)
        {
            return Post<List<InitialMarginModel>>(_subUrl + "/GetInitialMarginList", model);
        }

        public ResultWithModel<List<InitialMarginModel>> CreateInitialMargin(InitialMarginModel model)
        {
            return Post<List<InitialMarginModel>>(_subUrl + "/CreateInitialMargin", model);
        }

        public ResultWithModel<List<InitialMarginModel>> UpdateInitialMargin(InitialMarginModel model)
        {
            return Post<List<InitialMarginModel>>(_subUrl + "/UpdateInitialMargin", model);
        }

        public ResultWithModel<List<InitialMarginModel>> DeleteInitialMargin(InitialMarginModel model)
        {
            return Post<List<InitialMarginModel>>(_subUrl + "/DeleteInitialMargin", model);
        }
    }
}