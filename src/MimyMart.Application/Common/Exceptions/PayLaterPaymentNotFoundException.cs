namespace MimyMart.Application.Common.Exceptions;

public class PayLaterPaymentNotFoundException : Exception
{
    public PayLaterPaymentNotFoundException(string message) : base(message) { }
}