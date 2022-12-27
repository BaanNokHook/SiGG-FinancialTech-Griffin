using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class PaymentMethodAPI : WebClient
    {
        private static readonly string _subUrl = "PaymentMethod";

        public PaymentMethodAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLPaymentFlag(string payment_flag_item)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLPaymentFlag?payment_flag_item=" + payment_flag_item);
        }

        public ResultWithModel<List<PaymentMethodModel>> GetPaymentMethodList(PaymentMethodModel model)
        {
            return Post<List<PaymentMethodModel>>(_subUrl + "/GetPaymentMethodList", model);
        }

        public ResultWithModel<List<PaymentMethodModel>> GetPaymentMethodEdit(PaymentMethodModel model)
        {
            return Post<List<PaymentMethodModel>>(_subUrl + "/GetPaymentMethodEdit", model);
        }

        public ResultWithModel<List<PaymentMethodModel>> CreatePaymentMethod(PaymentMethodModel model)
        {
            return Post<List<PaymentMethodModel>>(_subUrl + "/CreatePaymentMethod", model);
        }

        public ResultWithModel<List<PaymentMethodModel>> UpdatePaymentMethod(PaymentMethodModel model)
        {
            return Post<List<PaymentMethodModel>>(_subUrl + "/UpdatePaymentMethod", model);
        }

        public ResultWithModel<List<PaymentMethodModel>> DeletePaymentMethod(PaymentMethodModel model)
        {
            return Post<List<PaymentMethodModel>>(_subUrl + "/DeletePaymentMethod", model);
        }
    }
}