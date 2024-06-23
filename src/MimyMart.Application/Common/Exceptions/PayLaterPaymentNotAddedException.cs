namespace MimyMart.Application.Common.Exceptions;

public class PayLaterPaymentNotAddedException : Exception
{
    public PayLaterPaymentNotAddedException(string message) : base(message) { }
}