using DesignPatterns.State.PaymentStates;

namespace DesignPatterns.State;

public class Payment
{
    public Guid Id { get; }

    public string Title { get; }
    public decimal Amount { get; }
    public string Category { get; private set; }
    public DateTime? DueDate { get; private set; }
    public ICollection<string> Label { get; private set; }
    public Guid? BeneficiaryId { get; private set; }
    public DateTime? IssuedDate { get; internal set; }
    public DateTime? PaidDate { get; internal set; }

    private PaymentState currentState;

    public Payment(string title, decimal amount, string category, DateTime dueDate, ICollection<string> label,
        Guid? beneficiaryId)
    {
        Id = Guid.NewGuid();
        Title = title;
        Amount = amount;
        Category = category;
        DueDate = dueDate;
        Label = label;
        BeneficiaryId = beneficiaryId;

        TransitionToState(new DraftPaymentState());
    }

    public void TransitionToState(PaymentState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    public void PayWith(PaymentMethod paymentMethod) => currentState.PayVia(this, paymentMethod);
    public void Cancel() => currentState.Cancel(this);
    public void MarkAsPaid(DateTime dateTime)
    {
        currentState.MarkAsPaid(this, dateTime);
    }
}