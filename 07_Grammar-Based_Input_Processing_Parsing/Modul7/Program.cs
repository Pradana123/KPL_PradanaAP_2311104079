using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        string[] values = { "1,304.16", "$1,456.78", "1,094", "152",
        "123,45 €", "1 304,16", "Ae9f" };
        double number;

        foreach (string value in values)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            try
            {
                number = Double.Parse(value, culture);
                Console.WriteLine("{0} : {1} --> {2}", culture.Name, value, number);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0}: Unable to parse '{1}'.", culture.Name, value);

                culture = CultureInfo.CreateSpecificCulture("fr-FR");
                try
                {
                    number = Double.Parse(value, culture);
                    Console.WriteLine("{0} : {1} --> {2}", culture.Name, value, number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}: Unable to parse '{1}'.", culture.Name, value);
                }
            }
            Console.WriteLine();
        }

        string dateInput = "Jan 1, 2009";
        var parsedDate = DateTime.Parse(dateInput);
        Console.WriteLine(parsedDate);

        string MyString1 = "A";
        char MyChar = Char.Parse(MyString1);

        string MyString2 = "True";
        bool MyBool = bool.Parse(MyString2);

        string MyString3 = "Thursday";
        DayOfWeek MyDays = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), MyString3);
        Console.WriteLine(MyDays);

        Console.WriteLine("\n======= Parsing Json =======");
        Jurnal.ReadJson();
        Console.ReadLine();
    }
}