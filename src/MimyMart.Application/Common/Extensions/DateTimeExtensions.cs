﻿namespace MimyMart.Application.Common.Extensions;

public static class DateTimeExtensions
{
    private static DateTime FirstDayOfWeek(this DateTime dateTime)
    {
        var culture = Thread.CurrentThread.CurrentCulture;
        var diff = dateTime.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;

        if (diff < 0)
            diff += 7;

        return dateTime.AddDays(-diff).Date;
    }

    public static DateTime LastDayOfWeek(this DateTime dateTime) => dateTime.FirstDayOfWeek().AddDays(6);

    public static DateTime FirstDayOfMonth(this DateTime dateTime) => new(dateTime.Year, dateTime.Month, 1);

    public static DateTime LastDayOfMonth(this DateTime dateTime) => dateTime.FirstDayOfMonth().AddMonths(1).AddDays(-1);

    public static DateTime FirstDayOfYear(this DateTime dateTime) => new(dateTime.Year, 1, 1);

    public static DateTime LastDayOfYear(this DateTime dateTime) => new(dateTime.Year, 12, 31);

	public static DateOnly ToDateOnly(this DateTime dateTime) => DateOnly.FromDateTime(dateTime);
}