// Deconstruct 

var (year, month, day) = DateTime.Now;

Console.WriteLine($"Şu anki tarih : {day} {month} {year}.");
Console.ReadKey();

public static class DateTimeExtensions
{
    // !! Deconstruct
    public static void Deconstruct(this DateTime datetime,
        out int year,
        out int month,
        out int day) => (year, month, day) = (datetime.Year,
        datetime.Month, datetime.Day);
}

