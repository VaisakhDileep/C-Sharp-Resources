/*
Created by  : Vaisakh Dileep
Date        : 30, December, 2021
Description : This program helps to understand the Console class in C#.
*/

Console.Write("Villain: "); // "Console.Write()" will print and keep the cursor on the same line.
Console.WriteLine("Lin Salvador\n"); // "Console.WriteLine()" will print and put the cursor in the new line.

int ASCII_value_1 = 0;
int ASCII_value_2 = 0; // Used to catch '\r'.
int ASCII_value_3 = 0; // Used to catch '\n'.

Console.Write("Enter any character: ");

ASCII_value_1 = Console.Read(); // "Console.Read()" will take a single input and returns the ASCII value of that input.
ASCII_value_2 = Console.Read(); // Since I am using windows the input string is terminated by "\r\n", so we need to catch them otherwise it will affect any future reads. This will catch '\r'.
ASCII_value_3 = Console.Read(); // This will catch '\n'.

Console.WriteLine("\nASCII_value_1: {0}", ASCII_value_1);
Console.WriteLine("ASCII_value_2: {0}", ASCII_value_2); // '13' is the ASCII value of Carriage Return('\r').
Console.WriteLine("ASCII_value_3: {0}", ASCII_value_3); // '10' is the ASCII value of Line Feed('\n').

char character = ' ';

Console.Write("\nEnter any character: ");

character = (char)Console.Read(); // If we need the output in "char" we need to explicitly convert to "char".

ASCII_value_2 = Console.Read();
ASCII_value_3 = Console.Read();

Console.WriteLine("\nEntered character: {0}", character);

Console.Write("\nConsole.ReadKey(): ");
Console.ReadKey(); // By default the value of the entered character is displayed. It is mainly used to halt the program execution until the user presses a key. It returns a "ConsoleKeyInfo" object.

ASCII_value_2 = Console.Read();
ASCII_value_3 = Console.Read();

Console.Write("Console.ReadKey(true): ");
Console.ReadKey(true); // By passing "true" the entered character is not displayed.

ASCII_value_2 = Console.Read();
ASCII_value_3 = Console.Read();

Console.Write("Console.ReadKey(false): ");
Console.ReadKey(false); // By passing "false" the entered character is displayed.

ASCII_value_2 = Console.Read();
ASCII_value_3 = Console.Read();

string name = "";

int age = 0;

Console.Write("\nEnter your name: ");
name = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nname: {0}", name);
Console.WriteLine("age : {0}", age);