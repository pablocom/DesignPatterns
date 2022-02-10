namespace DesignPatterns.State.PaymentStates;

public class DraftPaymentState : PaymentState
{
    public override void EnterState(Payment payment)
    {
        throw new NotImplementedException();
    }

    public override void Issue(Payment payment)
    {
        throw new NotImplementedException();
    }

    public override void Cancel(Payment payment)
    {
        throw new NotImplementedException();
    }

    public override void PaymentRejected(Payment payment)
    {
        throw new NotImplementedException();
    }

    public override void MarkAsPaid(Payment payment, DateTime executedAt)
    {
        throw new NotImplementedException();
    }
}