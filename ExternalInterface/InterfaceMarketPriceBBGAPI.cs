using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using GM.Model.Common;
using GM.Model.ExternalInterface;

namespace GM.ClientAPI.Endpoint.ExternalInterface
{
    public class InterfaceMarketPriceBBGAPI : WebClient 
    {
       private static readonly string _subUrl = "InterfaceMarketPriceBBG"; 

       public InterfaceMarketPriceBBGAPI(HttpClient client) : base(client)   
       {
       }  

        public ResultWithModel<List<InterfaceMarketPriceModel>> ImportMarketPriceBBG(InterfaceMarketPriceModel model)  
        {
            return Post<List<InterfaceMarketPriceModel>>(_subUrl + "/ImportMarketPriceBBG", model);     
        }  

        public ResultWithModel<DataSet> ImportMarketPriceBBGList(InterfaceMarketPriceModel model)
        {
            return Post<DataSet>(_subUrl + "/ImportMarketPriceBBGList", model);   
        }
    }
}