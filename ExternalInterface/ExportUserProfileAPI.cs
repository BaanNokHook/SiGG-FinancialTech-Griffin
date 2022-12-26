using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class ExportUserProfileAPI : WebClient  
    {
         private static readonly string _subUrl = "ExportUserProfile";  

         public ExportUserProfileAPI(HttpClient client) : base(client)  
         {
         }

         public ExportUserProfile(HttpClient client) : base(client)   
         {
         }

         public ResultWithModel<List<ExportUserProfileMonthlyMailModel>> ExportUserProfileMonthlyMail(ExportUserProfileMonthlyMailModel model)
         {
            return Post<List<ExportUserProfileMonthlyMailModel>>(_subUrl + "/ExportUserProfileMonthlyMail", model);
         }
    }
}