using System.Net.Http;
using GM.ClientAPI.Endpoint.ExternalInterface;

namespace GM.ClientAPI.Endpoint
{
    public class ExternalInterfaceEndpoint
    {
        public InterfaceDWHAPI InterfaceDWH { get; }
        public InterfaceConfirmationAPI InterfaceConfirmation { get; }
        public InterfaceMarketPriceBBGAPI InterfaceMarketPriceBBG { get; }
        public InterfaceMarketPriceTbmaFitsAPI InterfaceMarketPriceTbmaFitsAPI { get; }
        public InterfaceNavPriceEquityAPI InterfaceNavPriceEquity { get; }
        public InterfaceExchangeRateSummitAPI InterfaceExchangeRateSummit { get; }
        public InterfaceFloatingIndexSummitAPI InterfaceFloatingIndexSummit { get; }
        public InterfaceCounterRateExRateAPI InterfaceCounterRateExRate { get; }
        public InterfaceMidValuationExRateAPI InterfaceMidValuationExRate { get; }
        public InterfaceTransLimitCrAPI InterfaceTransLimitCr { get; }
        public InterfaceDMSAPI InterfaceDMS { get; }
        public InterfaceBondPledgeFitsAPI InterfaceBondPledgeFits { get; }
        public InterfaceFxAPI InterfaceFx { get; }
        public InterfaceGlAPI InterfaceGl { get; }
        public ExportAmendCancelAPI ExportAmendCancel { get; }
        public InterfaceCheckingEodAPI InterfaceCheckingEod { get; }
        public CheckSFTPAPI CheckSFTP { get; }
        public InterfaceTrpFitsAPI InterfaceTrpFits { get; }
        public InterfaceRpReferenceAPI InterfaceRpReference { get; }
        public ExportUserProfileAPI ExportUserProfile { get; }
        public InternalJobAPI InternalJob { get; }
        public InterfaceNesAPI InterfaceNES { get; }
        public InterfaceEquityPledgeAPI InterfaceEquityPledge { get; }

        public InterfaceThorRateAPI InterfaceThorRate { get; }
        public InterfaceThorIndexFitsAPI InterfaceThorIndex { get; }


        public ExternalInterfaceEndpoint(IHttpClientFactory httpClientFactory)
        {
            var client = httpClientFactory.CreateClient("ExternalInterfaceEndpoint");
            InterfaceDWH = new InterfaceDWHAPI(client);
            InterfaceConfirmation = new InterfaceConfirmationAPI(client);
            InterfaceMarketPriceBBG = new InterfaceMarketPriceBBGAPI(client);
            InterfaceMarketPriceTbmaFitsAPI = new InterfaceMarketPriceTbmaFitsAPI(client);
            InterfaceNavPriceEquity = new InterfaceNavPriceEquityAPI(client);
            InterfaceExchangeRateSummit = new InterfaceExchangeRateSummitAPI(client);
            InterfaceFloatingIndexSummit = new InterfaceFloatingIndexSummitAPI(client);
            InterfaceCounterRateExRate = new InterfaceCounterRateExRateAPI(client);
            InterfaceMidValuationExRate = new InterfaceMidValuationExRateAPI(client);
            InterfaceTransLimitCr = new InterfaceTransLimitCrAPI(client);
            InterfaceDMS = new InterfaceDMSAPI(client);
            InterfaceBondPledgeFits = new InterfaceBondPledgeFitsAPI(client);
            InterfaceFx = new InterfaceFxAPI(client);
            InterfaceGl = new InterfaceGlAPI(client);
            ExportAmendCancel = new ExportAmendCancelAPI(client);
            InterfaceCheckingEod = new InterfaceCheckingEodAPI(client);
            CheckSFTP = new CheckSFTPAPI(client);
            InterfaceTrpFits = new InterfaceTrpFitsAPI(client);
            InterfaceRpReference = new InterfaceRpReferenceAPI(client);
            ExportUserProfile = new ExportUserProfileAPI(client);
            InternalJob = new InternalJobAPI(client);
            InterfaceNES = new InterfaceNesAPI(client);
            InterfaceEquityPledge = new InterfaceEquityPledgeAPI(client);
            InterfaceThorRate = new InterfaceThorRateAPI(client);
            InterfaceThorIndex = new InterfaceThorIndexFitsAPI(client);
        }
    }
}
