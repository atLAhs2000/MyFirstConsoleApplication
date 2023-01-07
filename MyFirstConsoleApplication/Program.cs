// See https://aka.ms/new-console-template for more information
using System;

class GlazerCalc
{
    static void Main()
    {
        string name, location;
        DateOnly today, christmas;
        int daysUntilChristmas;

        name = "Alyssa";
        location = "California";
        today = DateOnly.FromDateTime(DateTime.Now);
        christmas = new DateOnly(2023, 12, 25);
        daysUntilChristmas = christmas.DayNumber - today.DayNumber; 

        Console.WriteLine("My name is " + name);
        Console.WriteLine("I am from " + location);
        Console.WriteLine("Today is " + today);
        Console.WriteLine("That means we've got " + daysUntilChristmas + " days until Christmas!\n");

        //below is the actual GlazerCalc program from the book
        Console.WriteLine("Let's calculate for glazing!");
        double width, height, woodlength, glassArea;
        string widthString, heightString;

        Console.WriteLine("Enter in the width:");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("Enter in the height:");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodlength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width + height);

        Console.WriteLine("The length of the wood is " + woodlength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres");

        Console.ReadKey();
    }
}

