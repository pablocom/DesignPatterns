using DesignPatterns.State.PaymentStates;

namespace DesignPatterns.State;

public class Payment
{
    public string Title { get; }
    public decimal Amount { get; }
    public string Category { get; private set; }
    public DateTime? DueDate { get; private set; }
    public ICollection<string> Label { get; private set; }
    public Guid? BeneficiaryId { get; private set; }
    public DateTime? ExecutionDate { get; private set; }

    private PaymentState currentState;

    public Payment(string title, decimal amount, string category, DateTime dueDate, ICollection<string> label,
        Guid? beneficiaryId)
    {
        Title = title;
        Amount = amount;
        Category = category;
        DueDate = dueDate;
        Label = label;
        BeneficiaryId = beneficiaryId;
    }

    public void TransitionToState(PaymentState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}