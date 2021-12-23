/*
Created by  : Vaisakh Dileep
Date        : 13, December, 2021
Description : This program helps to understand the char data type in C#.
*/

char char_variable = '\0';

Console.WriteLine("sizeof(char): {0}\n", sizeof(char));

Console.WriteLine("char                : [{0}, {1}]", (int)char.MinValue, (int)char.MaxValue); // "char.MinValue" will return in "char", therefore we need to explicitly convert it to an "int" value.
Console.WriteLine("char(in hexadecimal): [{0:X}, {1:X}]\n", (int)char.MinValue, (int)char.MaxValue);

ushort ushort_variable = char_variable;

int int_variable = char_variable;

uint uint_variable = char_variable;

long long_variable = char_variable;

ulong ulong_variable = char_variable;

float float_variable = char_variable;

double double_variable = char_variable;

decimal decimal_variable = char_variable; // "char" can be implicitly converted to "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal".

char_variable = 'F'; // We can use a character literal to assign to a "char" variable.

Console.WriteLine("char_variable: {0}", char_variable);

char_variable = '\u263A'; // When using Unicode representation, make sure to add '\u' before the hexadecimal representation.

Console.WriteLine("char_variable: {0}", char_variable);

char_variable = '\x263A'; // When using hexadecimal representation, make sure to add '\x' before the hexadecimal representation.

Console.WriteLine("char_variable: {0}", char_variable);