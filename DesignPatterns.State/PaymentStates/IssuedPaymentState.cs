namespace DesignPatterns.State.PaymentStates;

public class IssuedPaymentState : PaymentState
{
    private readonly DateTime issuedDate;

    public IssuedPaymentState(DateTime issuedDate)
    {
        this.issuedDate = issuedDate;
    }

    public override void EnterState(Payment payment)
    {
        payment.IssuedDate = this.issuedDate;
    }

    public override void PayVia(Payment payment, PaymentMethod paymentMethod)
    {
        throw new InvalidOperationException("Cannot pay already issued payment");
    }

    public override void Cancel(Payment payment)
    {
        payment.TransitionToState(new DraftPaymentState());
    }

    public override void PaymentRejected(Payment payment)
    {
        throw new NotImplementedException();
    }

    public override void MarkAsPaid(Payment payment, DateTime executedAt)
    {
        payment.TransitionToState(new PaidPaymentState(executedAt));
    }
}