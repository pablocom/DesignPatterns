namespace DesignPatterns.State.PaymentStates;

public abstract class PaymentState
{
    public abstract void EnterState(Payment payment);
    
    public abstract void PayVia(Payment payment, PaymentMethod paymentMethod);
    public abstract void Cancel(Payment payment);
    public abstract void PaymentRejected(Payment payment);
    public abstract void MarkAsPaid(Payment payment, DateTime executedAt);
}