/*
Created by  : Vaisakh Dileep
Date        : 12, December, 2021
Description : This program helps to understand the floating numeric type in C#.
*/

float float_variable = 0; // "float" has a precision of ~6-9 digits.

double double_variable = 0; // "double" has a precision of ~15-17 digits.

decimal decimal_variable = 0; // "decimal" has a precision of ~28-29 digits.

Console.WriteLine("sizeof(int)    : {0}", sizeof(int));
Console.WriteLine("sizeof(double) : {0}", sizeof(double));
Console.WriteLine("sizeof(decimal): {0}\n", sizeof(decimal));

Console.WriteLine("float  : [{0}, {1}]", float.MinValue, float.MaxValue);
Console.WriteLine("double : [{0}, {1}]", double.MinValue, double.MaxValue);
Console.WriteLine("decimal: [{0}, {1}]\n", decimal.MinValue, decimal.MaxValue);

Console.WriteLine("float.NaN             : {0}", float.NaN);
Console.WriteLine("float.NegativeInfinity: {0}", float.NegativeInfinity);
Console.WriteLine("float.PositiveInfinity: {0}\n", float.PositiveInfinity);

Console.WriteLine("double.NaN             : {0}", double.NaN);
Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
Console.WriteLine("double.PositiveInfinity: {0}\n", double.PositiveInfinity); // NaN, NegativeInfinity, PositiveInfinity are defined for "float" and "double" data-types.

float_variable = 10.0F; // We could also use "10.0f", by default the literal is treated as a double value, we need to explicitly convert it to a float value using the 'F' suffix.

decimal_variable = 10.0M; // We could also use "10.0m", by default the literal is treated as a double value, we need to explicitly convert it to a decimal value using the 'M' suffix.

double_variable = 10.0; // We could also use "10.0D" or "10.0d".

double_variable = 10e5; // We could also use "10E5".

Console.WriteLine("double_variable: {0}", double_variable);