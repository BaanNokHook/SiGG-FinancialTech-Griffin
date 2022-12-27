using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Security;

namespace GM.ClientAPI.Endpoint.Static
{
    public class SecurityAPI : WebClient
    {
        private static readonly string _subUrl = "Security";

        public SecurityAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<SecurityModel>> GetSecurityList(SecurityModel model)
        {
            return Post<List<SecurityModel>>(_subUrl + "/GetSecurityList", model);
        }

        public ResultWithModel<List<SecurityModel>> CreateSecurity(SecurityModel model)
        {
            return Post<List<SecurityModel>>(_subUrl + "/CreateSecurity", model);
        }

        public ResultWithModel<List<SecurityModel>> UpdateSecurity(SecurityModel model)
        {
            return Post<List<SecurityModel>>(_subUrl + "/UpdateSecurity", model);
        }

        public ResultWithModel<List<SecurityModel>> DeleteSecurity(SecurityModel model)
        {
            return Post<List<SecurityModel>>(_subUrl + "/DeleteSecurity", model);
        }

        public ResultWithModel<List<SecurityGuarantorModel>> GetSecurityGuarantorList(SecurityGuarantorModel model)
        {
            return Post<List<SecurityGuarantorModel>>(_subUrl + "/GetSecurityGuarantorList", model);
        }

        public ResultWithModel<List<SecurityBondRatingModel>> GetSecurityRatingList(SecurityBondRatingModel model)
        {
            return Post<List<SecurityBondRatingModel>>(_subUrl + "/GetSecurityRatingList", model);
        }

        public ResultWithModel<List<SecurityEventModel>> GetSecurityEventsList(SecurityEventModel model)
        {
            return Post<List<SecurityEventModel>>(_subUrl + "/GetSecurityEventsList", model);
        }

        public ResultWithModel<List<SecurityAdditionalCodeModel>> GetSecurityAdditionalCodeList(SecurityAdditionalCodeModel model)
        {
            return Post<List<SecurityAdditionalCodeModel>>(_subUrl + "/GetSecurityAdditionalCodeList", model);
        }

        #region Dropdown
        public ResultWithModel<List<DDLItemModel>> GetDDLProduct(string instrumenttype, string product_name)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLProduct?instrumenttype=" + instrumenttype + "&product_name=" + product_name);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLSubProduct(string product_code, string sub_product)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLSubProduct?product_code=" + product_code + "&sub_product=" + sub_product);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLBondType(string instrumenttypename, string product_code)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLBondType?instrumenttypename=" + instrumenttypename + "&product_code=" + product_code);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLBondSubType(string bondsubtypedesc, string product_code, string instrumenttypename)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLBondSubType?bondsubtypedesc=" + bondsubtypedesc + "&product_code=" + product_code + "&instrumenttypename=" + instrumenttypename);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLIssuer(string issuername)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLIssuer?issuername=" + issuername);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLRegister(string registername)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLRegister?registername=" + registername);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLOptionType(string optionname)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLOptionType?optionname=" + optionname);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLSeniorityType(string senioritytypename)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLSeniorityType?senioritytypename=" + senioritytypename);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLMarketCode(string marketname)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLMarketCode?marketname=" + marketname);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCur(string curtext)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLCur?curtext=" + curtext);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLHolidayCur(string curtext)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLHolidayCur?curtext=" + curtext);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLYearBasis(string yearbasistext)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLYearBasis?yearbasistext=" + yearbasistext);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLTBMAListed(string tbmalisttext)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLTbmaListed?tbmalisttext=" + tbmalisttext);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLGuarantorCode(string guarantorname)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLGuarantorCode?guarantorname=" + guarantorname);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLInstrumentCode(string instrumentname)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLInstrumentCode?instrumentname=" + instrumentname);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLISINCode(string text)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLISINCode?text=" + text);
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCouponType(string text)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLCouponType?text=" + text);
        }
        #endregion
    }
}