namespace DesignPatterns.State.PaymentStates;

public sealed class DraftPaymentState : PaymentState
{
    public override void EnterState(Payment payment)
    {

    }

    public override void PayVia(Payment payment, PaymentMethod paymentMethod)
    {
        if (paymentMethod == PaymentMethod.PivotAccount)
        {
            payment.TransitionToState(new IssuedPaymentState(DateTime.UtcNow));
            return;
        }

        payment.TransitionToState(new PaidPaymentState(DateTime.UtcNow));
    }

    public override void Cancel(Payment payment)
    {
        throw new InvalidOperationException("Cannot cancel a payment in Draft state");
    }

    public override void PaymentRejected(Payment payment)
    {
        throw new InvalidOperationException("Cannot reject a payment in Draft state");
    }

    public override void MarkAsPaid(Payment payment, DateTime executionDate)
    {
        payment.TransitionToState(new PaidPaymentState(executionDate));
    }
}