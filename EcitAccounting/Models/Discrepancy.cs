namespace EcitAccounting.Models;

public class Discrepancy
{
    public string Id { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public string Severity { get; set; } = string.Empty;
    
}