using System;

class Ctp
{
    static void Main()
    {
        Payment payment = new Payment();
        payment.MakePayment(1000.00);
        payment.MakePayment(500.00, "user@upi");
        payment.MakePayment(2000.00, "1234-5678-9012-3456", "123");
    }
}

class Payment
{
    public void MakePayment(double amount)
    {
        Console.WriteLine("Payment made in cash: " + amount);
    }
    public void MakePayment(double amount, string UpiId)
    {
        Console.WriteLine("Payment made using UPI: " + UpiId + ", Amount: " + amount);
    }
    public void MakePayment(double amount, string cardNumber, string cvv)
    {
        Console.WriteLine("Payment made using Card: " + cardNumber + ", CVV: " + cvv + ", Amount: " + amount);
    }
}