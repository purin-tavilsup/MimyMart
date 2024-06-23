namespace MimyMart.Application.Common.Extensions;

public static class BooleanExtensions
{
    public static bool IsFalse(this bool value)
    {
        return value == false;
    }
}