using System.Net.Http;
using GM.ClientAPI.Endpoint.Static;

namespace GM.ClientAPI.Endpoint
{
    public class StaticEndpoint
    {
        public AgencyAPI Agency { get; }
        public RatingAPI Rating { get; }
        public SecurityAPI Security { get; }
        public BusinessDateAPI BusinessDate { get; }
        public CountryAPI Country { get; }
        public CustodianAPI Custodian { get; }
        public DistrictAPI District { get; }
        public SubDistrictAPI SubDistrict { get; }
        public ProvinceAPI Province { get; }
        public KtbIsicAPI KtbIsic { get; }
        public MarginAPI Margin { get; }
        public TitleAPI Title { get; }
        public PaymentMethodAPI PaymentMethod { get; }
        public CurrencyAPI Currency { get; }
        public HolidayAPI Holiday { get; }
        public ConfigAPI Config { get; }
        public RpConfigAPI RpConfig { get; }
        public AccountingAPI Accounting { get; }
        public TestPageAPI TestPage { get; }
        public TestConnectAPI TestConnect { get; }
        public LogInOutAPI LogInOut { get; }
        public TransLeqAPI TransLeq { get; }
        public DmsAPI DMS { get; }
        public DwhAPI DWH { get; }
        public InitialMarginAPI InitialMargin { get; }
        public PurposeAPI Purpose { get; }

        public StaticEndpoint(IHttpClientFactory httpClientFactory)
        {
            var client = httpClientFactory.CreateClient("StaticEndpoint");
            Agency = new AgencyAPI(client);
            Rating = new RatingAPI(client);
            Security = new SecurityAPI(client);
            BusinessDate = new BusinessDateAPI(client);
            Country = new CountryAPI(client);
            Custodian = new CustodianAPI(client);
            District = new DistrictAPI(client);
            SubDistrict = new SubDistrictAPI(client);
            Province = new ProvinceAPI(client);
            KtbIsic = new KtbIsicAPI(client);
            Margin = new MarginAPI(client);
            Title = new TitleAPI(client);
            PaymentMethod = new PaymentMethodAPI(client);
            Currency = new CurrencyAPI(client);
            Holiday = new HolidayAPI(client);
            Config = new ConfigAPI(client);
            RpConfig = new RpConfigAPI(client);
            Accounting = new AccountingAPI(client);
            TestPage = new TestPageAPI(client);
            TestConnect = new TestConnectAPI(client);
            LogInOut = new LogInOutAPI(client);
            TransLeq = new TransLeqAPI(client);
            DMS = new DmsAPI(client);
            DWH = new DwhAPI(client);
            InitialMargin = new InitialMarginAPI(client);
            Purpose = new PurposeAPI(client);
        }
    }
}
