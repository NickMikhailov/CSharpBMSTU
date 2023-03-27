// See https://aka.ms/new-console-template for more information

using _01_TeachMeHowToPrint;

Console.WriteLine("Hello! This application should learn you how to type!\nPress Enter to start or any other key to Exit\n");

while (Console.ReadKey().KeyChar == 13)
{
//  Console.WriteLine("\n" + Library.printText() + "\nJust start to type\n(press Enter to finish)"); // версия с одним текстом
    Console.WriteLine("\n" + Library.printRandomText() + "\nJust start to type\n(press Enter to finish)\n"); //версия с разными текстами
    Console.ReadKey();
    DateTime startedAt = DateTime.Now;
    string? textTyped = Console.ReadLine();
    TimeSpan span = DateTime.Now - startedAt;

    if (textTyped == null || textTyped == "")
    {
        Console.WriteLine("\nYour typed nothing!\n");
    }
    else
    {
        Console.WriteLine("\nYour time is " + span + " sec");
        double speed = Math.Round(textTyped.Length / (span.TotalMinutes));
        Console.WriteLine("Your typing speed is " + speed + " symbols per min");
    }
    Console.WriteLine("\nTry again? \n(press Enter to Restart or any other key to Exit)");
    }