using System.Data;
using EcitAccounting.Models;var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapGet("/api/reconciliation-feed", () =>
{
    var data = GetMockData();
    return Results.Ok(new
    {
        data
    });
    
    
});
app.Run();
static List<AccountReconciliation> GetMockData()
{
    return new List<AccountReconciliation>
    {   
        new AccountReconciliation {
        AccountId = "account_001",
        AccountName = "Operating Account",
        Instition = "DnB",
        Currency= "USD",
        Balance = 1000,
        Status = ReconciliationStatus.Reconciled,
        LastReconciledAt = DateTime.UtcNow.AddDays(-1),
        Discrepancies = new List<Discrepancy>()
        }, new AccountReconciliation
        {
            AccountId = "account_002",
            AccountName = "Tax account",
            Instition = "Bulder",
            Currency = "NOK",
            Balance = 50000, 
            Status = ReconciliationStatus.Flagged,
            LastReconciledAt = DateTime.UtcNow.AddDays(-6),
            Discrepancies = new List<Discrepancy>
            {
                new Discrepancy
                {
                    Id = "d1",
                    Type = "balance_mismatch",
                    Message = "Ledger and bank statement mismatch",
                    Severity = "High"
                }
            }
        }
        
    };
}
