using System.Net.Http;
using GM.Model.Common;
using GM.Model.InterfaceRpReference;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceRpReferenceAPI : WebClient  
    {
         private static readonly string _subUrl = "InterfaceRpReference";  
  
         public InterfaceRpReferenceAPI(HttpClient client) : base(client)  
         {
         }  

         public ResultWithModel<ResRpReference> ImportRpReference(string processDate, string settlementDay, ReqRpReference model)   
         {
            return Post<ReqRpReference>(_subUrl + "/ImportRpReference?processDate=" + processDate + "&settlementDay=" + settlementDay, model);   
         }
    }
}