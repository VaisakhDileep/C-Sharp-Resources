/*
Created by  : Vaisakh Dileep
Date        : 3, January, 2022
Description : This program helps to understand how to change the color of the console in C#.
*/

Console.ForegroundColor = System.ConsoleColor.Black;
Console.BackgroundColor = System.ConsoleColor.Blue;

Console.Clear(); // We need to use "Console.Clear()", otherwise the background color will only be changed for the text(not the whole console).

Console.WriteLine("Federal Bureau of Control");
Console.WriteLine("-------------------------\n");
Console.WriteLine("Director: Zachariah Trench\n");

Console.Write("Enter any key: ");
Console.ReadKey();

Console.ForegroundColor = System.ConsoleColor.Red;
Console.BackgroundColor = System.ConsoleColor.DarkGray;

Console.Clear(); // "Console.Clear()" will clear the console screen.

Console.WriteLine("Federal Bureau of Control");
Console.WriteLine("-------------------------\n");
Console.WriteLine("Director: Jesse Faden");