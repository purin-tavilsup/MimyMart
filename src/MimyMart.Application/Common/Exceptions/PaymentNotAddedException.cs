﻿namespace MimyMart.Application.Common.Exceptions;

public class PaymentNotAddedException : Exception
{
    public PaymentNotAddedException(string message) : base(message) { }
}