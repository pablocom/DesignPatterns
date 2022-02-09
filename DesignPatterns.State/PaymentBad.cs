namespace DesignPatterns.State;

public class PaymentBad
{
    public string Title { get; }
    public decimal Amount { get; }
    public string Category { get; private set; }
    public DateTimeOffset DueDate { get; private set; }
    public ICollection<string> Label { get; private set; }
    public Guid? BeneficiaryId { get; private set; }
    public PaymentStatus Status { get; private set; }

    public PaymentBad(string title, decimal amount, string category, DateTimeOffset dueDate, ICollection<string> label,
        Guid? beneficiaryId)
    {
        Title = title;
        Amount = amount;
        Category = category;
        DueDate = dueDate;
        Label = label;
        BeneficiaryId = beneficiaryId;
        Status = PaymentStatus.Draft;
    }

    public void PayViaSepaCreditTransferExport()
    {
        if (Status != PaymentStatus.Draft)
            throw new InvalidOperationException("Only draft payments can be issued");

        Status = PaymentStatus.Paid;
    }
    
    public void IssueViaPivotAccount()
    {
        if (Status != PaymentStatus.Draft)
            throw new InvalidOperationException("Only draft payments can be issued");

        Status = PaymentStatus.Issued;
    }

    public void MarkAsExecutedViaPivotAccount()
    {
        if (Status != PaymentStatus.Issued)
            throw new InvalidOperationException("Only issued payments can be mark as executed");

        Status = PaymentStatus.Paid;
    }
}