using System;
using Microsoft.SqlServer.Server;
using Impacta.WcfClient;

public partial class StoredProcedures
{
    /// <summary>
    /// To enable this procedure in SQL Server: https://code.msdn.microsoft.com/Calling-WCF-Service-from-a-8071ceaa
    /// </summary>
    /// <param name="quote"></param>
    [SqlProcedure]
    public static void GetStockQuote(string quote)
    {
        try
        {
            SqlContext.Pipe.Send(Stock.Get("MSFT"));
        }
        catch (Exception ex)
        {
            SqlContext.Pipe.Send(ex.Message);
        }
    }
}