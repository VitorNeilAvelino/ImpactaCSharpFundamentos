using Impacta.WcfClient.StockServiceReference;

namespace Impacta.WcfClient
{
    public class Stock
    {
        public static string Get(string quote)
        {
            using (var stockClient = new StockQuoteSoapClient())
            {
                return stockClient.GetQuote(quote);
            }
        }
    }
}