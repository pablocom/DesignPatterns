namespace DesignPatterns.State.PaymentStates;

public class IssuedPaymentState : PaymentState
{
    private readonly DateTime _issuedDate;

    public IssuedPaymentState(DateTime issuedDate)
    {
        this._issuedDate = issuedDate;
    }

    public override void EnterState(Payment payment)
    {
        payment.IssuedDate = _issuedDate;
    }

    public override void PayVia(Payment payment, PaymentMethod paymentMethod)
    {
        throw new InvalidOperationException("Cannot pay already issued payment");
    }

    public override void Cancel(Payment payment)
    {
        payment.TransitionToState(new DraftPaymentState());
    }

    public override void Reject(Payment payment)
    {
        throw new NotImplementedException();
    }

    public override void MarkAsPaid(Payment payment, DateTime executedAt)
    {
        payment.TransitionToState(new PaidPaymentState(executedAt));
    }
}