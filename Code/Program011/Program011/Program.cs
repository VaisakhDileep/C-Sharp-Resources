/*
Created by  : Vaisakh Dileep
Date        : 4, January, 2022
Description : This program helps to understand casting in C#.
*/

/*
Implicit casting: Conversion is done automatically. Conversion happens from a smaller type to a larger type.
egs: char -> int -> long -> float -> double
 */

char char_variable = 'a';

int int_variable = char_variable;

long long_variable = int_variable;

float float_variable = long_variable;

double double_variable = float_variable;

Console.WriteLine("char_variable  : {0}", char_variable);
Console.WriteLine("int_variable   : {0}", int_variable);
Console.WriteLine("long_variable  : {0}", long_variable);
Console.WriteLine("float_variable : {0}", float_variable);
Console.WriteLine("double_variable: {0}\n", double_variable);

/*
Explicit casting: Conversion is done manually. Conversion happens from larger type to smaller type.
egs: double -> float -> long -> int -> char
*/

double_variable = 120.888888888;

float_variable = (float)double_variable;

long_variable = (long)float_variable;

int_variable = (int)long_variable;

char_variable = (char)int_variable;

Console.WriteLine("char_variable  : {0}", char_variable);
Console.WriteLine("int_variable   : {0}", int_variable);
Console.WriteLine("long_variable  : {0}", long_variable);
Console.WriteLine("float_variable : {0}", float_variable);
Console.WriteLine("double_variable: {0}\n", double_variable);

bool bool_variable = true;

string char_variable_string = char_variable.ToString(); // We can explicitly convert a data-type to string by using "ToString()" member method.

string int_variable_string = int_variable.ToString();

string long_variable_string = long_variable.ToString();

string float_variable_string = float_variable.ToString();

string double_variable_string = double_variable.ToString();

string bool_variable_string = bool_variable.ToString();

Console.WriteLine("char_variable_string  : {0}", char_variable_string);
Console.WriteLine("int_variable_string   : {0}", int_variable_string);
Console.WriteLine("long_variable_string  : {0}", long_variable_string);
Console.WriteLine("float_varaible_string : {0}", float_variable_string);
Console.WriteLine("double_variable_string: {0}", double_variable_string);
Console.WriteLine("bool_variable_string  : {0}", bool_variable_string);