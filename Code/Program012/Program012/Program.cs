/*
Created by  : Vaisakh Dileep
Date        : 5, January, 2022
Description : This program helps to understand how to parse a string to a different data type in C#.
*/

string sbyte_variable_string = "-12";

string byte_variable_string = "12";

string short_variable_string = "-123";

string ushort_variable_string = "123";

string int_variable_string = "-12345";

string uint_variable_string = "12345";

string long_variable_string = "-12345678910111213";

string ulong_variable_string = "12345678910111213";

string float_variable_string = "3.14159265358979323846264338";

string double_variable_string = "3.14159265358979323846264338";

string decimal_variable_string = "3.14159265358979323846264338";

string char_variable_string = "a";

string bool_variable_string = "true";

Console.WriteLine("sbyte_variable_string  : {0}", sbyte_variable_string);
Console.WriteLine("byte_variable_string   : {0}", byte_variable_string);
Console.WriteLine("short_variable_string  : {0}", short_variable_string);
Console.WriteLine("ushort_variable_string : {0}", ushort_variable_string);
Console.WriteLine("int_variable_string    : {0}", int_variable_string);
Console.WriteLine("uint_variable_string   : {0}", uint_variable_string);
Console.WriteLine("long_variable_string   : {0}", long_variable_string);
Console.WriteLine("ulong_variable_string  : {0}", ulong_variable_string);
Console.WriteLine("float_variable_string  : {0}", float_variable_string);
Console.WriteLine("double_variable_string : {0}", double_variable_string);
Console.WriteLine("decimal_variable_string: {0}", decimal_variable_string);
Console.WriteLine("char_variable_string   : {0}", char_variable_string);
Console.WriteLine("bool_variable_string   : {0}\n", bool_variable_string);

sbyte sbyte_variable = sbyte.Parse(sbyte_variable_string); // Every data-type has a member method called ".Parse()" which can be used to convert a valid string to the corresponding data-type.

byte byte_variable = byte.Parse(byte_variable_string);

short short_variable = short.Parse(short_variable_string);

ushort ushort_variable = ushort.Parse(ushort_variable_string);

int int_variable = int.Parse(int_variable_string);

uint uint_variable = uint.Parse(uint_variable_string);

long long_variable = long.Parse(long_variable_string);

ulong ulong_variable = ulong.Parse(ulong_variable_string);

float float_variable = float.Parse(float_variable_string);

double double_variable = double.Parse(double_variable_string);

decimal decimal_variable = decimal.Parse(decimal_variable_string);

char char_variable = char.Parse(char_variable_string);

bool bool_variable = bool.Parse(bool_variable_string);

Console.WriteLine("sbyte_variable  : {0}", sbyte_variable);
Console.WriteLine("byte_variable   : {0}", byte_variable);
Console.WriteLine("short_variable  : {0}", short_variable);
Console.WriteLine("ushort_variable : {0}", ushort_variable);
Console.WriteLine("int_variable    : {0}", int_variable);
Console.WriteLine("uint_variable   : {0}", uint_variable);
Console.WriteLine("long_variable   : {0}", long_variable);
Console.WriteLine("ulong_variable  : {0}", ulong_variable);
Console.WriteLine("float_variable  : {0}", float_variable);
Console.WriteLine("double_variable : {0}", double_variable);
Console.WriteLine("decimal_variable: {0}", decimal_variable);
Console.WriteLine("char_variable   : {0}", char_variable);
Console.WriteLine("bool_variable   : {0}", bool_variable);

int_variable_string = "150$";

// int_variable = int.Parse(int_variable_string); // This line of code will give an exception and causes the program to terminate.