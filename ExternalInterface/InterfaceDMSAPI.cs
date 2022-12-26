using System.Collections.Generic;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{

    public class InterfaceDMSAPI : WebClient  
    {
        private static readonly string _subUrl = "InterfaceDMS";   
        {
        }  

        public ResultWithModel<List<InterfaceDmsSftpModel>> ExportInterfaceDms(InterfaceDmsSftpModel model)
        {
            return Post<List<InterfaceDmsSftpModel>>(_subUrl + "/ExportInterfaceDms", model);
        }

        public ResultWithModel<List<InterfaceDmsSftpModel>> ExportInterfaceDmsMonthly(InterfaceDmsSftpModel model)
        {
            return Post<List<InterfaceDmsSftpModel>>(_subUrl + "/ExportInterfaceDmsMonthly", model);
        }
    }
}