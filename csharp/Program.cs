using System.Globalization;

var culture = "zh-TW";
var ci = CultureInfo.GetCultureInfo(culture);

Console.WriteLine($"DateTimeFormat for {ci.Name}");

Console.WriteLine($"FullDateTimePattern : {ci.DateTimeFormat.FullDateTimePattern}");
Console.WriteLine($"LongDatePattern : {ci.DateTimeFormat.FullDateTimePattern}");
Console.WriteLine($"LongTimePattern : {ci.DateTimeFormat.LongTimePattern}");
Console.WriteLine($"ShortDatePattern : {ci.DateTimeFormat.ShortDatePattern}");
Console.WriteLine($"ShortTimePattern : {ci.DateTimeFormat.ShortTimePattern}");
Console.WriteLine($"AM/PM Designator : {ci.DateTimeFormat.AMDesignator}/{ci.DateTimeFormat.PMDesignator}");

Console.WriteLine($"YearMonthPattern : {ci.DateTimeFormat.YearMonthPattern}");
Console.WriteLine($"MonthDayPattern : {ci.DateTimeFormat.MonthDayPattern}");

