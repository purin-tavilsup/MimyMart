﻿namespace MimyMart.Application.Common.Exceptions;

public class ProductNotUpdatedException : Exception
{
    public ProductNotUpdatedException(string message) : base(message) { }
}