using DesignPatterns.State;

Payment BuildPayment()
{
    return new Payment(
        "Salaries March 2021", 
        6969.32m,
        "Salaries",
        DateTime.SpecifyKind(new DateTime(2021, 1, 3), DateTimeKind.Utc), 
        new List<string> {"IT", "Blabla"}, 
        Guid.NewGuid());
}


var payment = BuildPayment();

payment.PayWith(PaymentMethod.PivotAccount);
payment.Cancel();
payment.MarkAsPaid(DateTime.UtcNow);
payment.Reject();
