using DesignPatterns.State;

var payment = new Payment(
    "Salaries March 2021", 
    6969.32m,
    string.Empty,
    new DateTime(2021, 1, 3, 0, 0, 0, DateTimeKind.Utc), 
    new List<string> {"Salaries"}, 
    Guid.NewGuid());

payment.PayWith(PaymentMethod.PivotAccount);
payment.MarkAsPaid(DateTime.UtcNow);

payment.Cancel();