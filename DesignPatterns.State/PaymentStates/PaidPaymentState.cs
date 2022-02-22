namespace DesignPatterns.State.PaymentStates;

public class PaidPaymentState : PaymentState
{
    private readonly DateTime datePaid;

    public PaidPaymentState(DateTime datePaid)
    {
        this.datePaid = datePaid;
    }

    public override void EnterState(Payment payment)
    {
        payment.PaidDate = datePaid;
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

    public override void PaymentRejected(Payment payment)
    {
        throw new InvalidOperationException("A paid payment cannot be canceled");
    }

    public override void MarkAsPaid(Payment payment, DateTime executedAt)
    {
        
    }
}