using System;

namespace GenericsExample;
public class BankAccount
{
    public string Id { get; set; }
    public string IdentifierNumber { get; set; }
    public decimal CurrentBalance { get; set; }
    public decimal? BalanceLimit{ get; set; }
    public DateTime CreatedDate{ get; set; }
    public DateTime? ModifiedDate{ get; set; }

    public override string ToString()
        => $"Id: {Id}, Identifier number: {IdentifierNumber}, Current Balance: {CurrentBalance}, Balance limit: {BalanceLimit}, Created Date: {CreatedDate:yyyy MMMM dd}, Modified date: {(ModifiedDate.HasValue ? ModifiedDate.Value.ToString("yyyy MMMM dd") : "-")}";
}
