/*
Created by  : Vaisakh Dileep
Date        : 20, November, 2021
Description : This program prints "Hello, World!" in C#.
*/

// Starting from .NET 6, new projects using the console template won't have to go through the tradition template.

/*
Traditional .NET console template(before .NET 6):
namespace Program001 // Project name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!);
        }
    }
}
*/

Console.WriteLine("Hello, World!");

Console.Read(); // This will keep the console from automatically closing(if we are explicitly opening the .exe file).