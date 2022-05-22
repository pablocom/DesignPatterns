using DesignPatterns.State.PaymentStates;

namespace DesignPatterns.State;

public class Payment
{
    public Guid Id { get; }
    public string Title { get; }
    public decimal Amount { get; }
    public string Category { get; }
    public DateTime? DueDate { get; }
    public ICollection<string> Label { get; }
    public Guid? BeneficiaryId { get; }
    public DateTime? IssuedDate { get; internal set; }
    public DateTime? PaidDate { get; internal set; }

    private PaymentState _currentState;

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
        _currentState = state;
        _currentState.EnterState(this);
    }

    public void PayWith(PaymentMethod paymentMethod) => _currentState.PayVia(this, paymentMethod);
    public void Cancel() => _currentState.Cancel(this);
    public void MarkAsPaid(DateTime executionDate) => _currentState.MarkAsPaid(this, executionDate);
    public void Reject() => _currentState.Reject(this);
}