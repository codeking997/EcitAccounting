namespace EcitAccounting.Models;

public class AccountReconciliation
{
    public string AccountId { get; set; } = string.Empty;

    public string AccountName { get; set; } = string.Empty;

    public string Instition { get; set; } = string.Empty;

    public string Currency { get; set; } = string.Empty;
    
    
    public decimal Balance { get; set; }
    
    public ReconciliationStatus Status { get; set; }
    
    public DateTime? LastReconciledAt { get; set; }

    public List<Discrepancy> Discrepancies { get; set; } = [];
}