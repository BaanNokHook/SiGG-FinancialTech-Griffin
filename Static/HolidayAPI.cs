using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.Static;

namespace GM.ClientAPI.Endpoint.Static
{
    public class HolidayAPI : WebClient
    {
        private static readonly string _subUrl = "Holiday";

        public HolidayAPI(HttpClient client) : base(client)
        {
        }

        public ResultWithModel<List<DDLItemModel>> GetDDLCurrency(string cur)
        {
            return Get<List<DDLItemModel>>(_subUrl + "/GetDDLCurrency?cur=" + cur);
        }

        public ResultWithModel<List<HolidayModel>> GetHolidayList(HolidayModel model)
        {
            return Post<List<HolidayModel>>(_subUrl + "/GetHolidayList", model);
        }

        public ResultWithModel<List<HolidayModel>> GetHolidayEdit(HolidayModel model)
        {
            return Post<List<HolidayModel>>(_subUrl + "/GetHolidayEdit", model);
        }

        public ResultWithModel<List<HolidayModel>> CreateHoliday(List<HolidayModel> model)
        {
            return Post<List<HolidayModel>>(_subUrl + "/CreateHoliday", model);
        }

        public ResultWithModel<List<HolidayModel>> UpdateHoliday(HolidayModel model)
        {
            return Post<List<HolidayModel>>(_subUrl + "/UpdateHoliday", model);
        }

        public ResultWithModel<List<HolidayModel>> DeleteHoliday(HolidayModel model)
        {
            return Post<List<HolidayModel>>(_subUrl + "/DeleteHoliday", model);
        }

        public ResultWithModel<List<RpHolidayModel>> CheckHoliday(RpHolidayModel model)
        {
            return Post<List<RpHolidayModel>>(_subUrl + "/CheckHoliday", model);
        }
    }
}