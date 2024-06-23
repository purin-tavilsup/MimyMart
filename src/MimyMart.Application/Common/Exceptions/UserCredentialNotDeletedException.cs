namespace MimyMart.Application.Common.Exceptions;

public class UserCredentialNotDeletedException : Exception
{
    public UserCredentialNotDeletedException(string message) : base(message) { }
}