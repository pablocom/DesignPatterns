namespace DesignPatterns.State.PaymentStates;

public class PaidPaymentState : PaymentState
{
    private readonly DateTime _datePaid;

    public PaidPaymentState(DateTime datePaid)
    {
        this._datePaid = datePaid;
    }

    public override void EnterState(Payment payment)
    {
        payment.PaidDate = _datePaid;
        // Example: raise domain event to send an email notification
    }

    public override void PayVia(Payment payment, PaymentMethod paymentMethod)
    {
        throw new InvalidOperationException($"Cannot pay an already paid payment. PaymentId: {payment.Id}");
    }

    public override void Cancel(Payment payment)
    {
        throw new InvalidOperationException("A paid payment cannot be canceled");
    }

    public override void Reject(Payment payment)
    {
        throw new InvalidOperationException("A paid payment cannot be rejected");
    }

    public override void MarkAsPaid(Payment payment, DateTime executedAt)
    {
        
    }
}