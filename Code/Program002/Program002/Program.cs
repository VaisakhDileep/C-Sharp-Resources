/*
Created by  : Vaisakh Dileep
Date        : 23, November, 2021
Description : This program helps to understand variables and data types in C#.
*/

/*
Rules for naming a variable:
1. variable names must be unique.
2. variable names can contain letters, digits and underscore('_') only.
3. variables should start with either a letter or an underscore('_').
4. variable names cannot be a keyword. We can use reserved keywords as variable name by adding '@' before it.
*/

int @int = 0; // Here "int" is a reserved keyword, but we can still use it as a variable name by adding '@' before it.

Console.WriteLine("@int: {0}\n", @int);

int int_variable = 0; // Uninitialized int variable will give a build error.

Console.WriteLine("int_variable: {0}", int_variable); // "{n}" will be replaced by the (n+1)'th parameter of the function "Console.WriteLine()" (indexing starts from '0'). "Console.WriteLine()" will automatically add a new line at the end.

sbyte sbyte_variable = 0; // "sbyte"(signed byte) will hold integers with value ranging from -128 to 127.

Console.WriteLine("sbyte_variable: {0}", sbyte_variable);

short short_variable = 0; // "short" will hold integers with value ranging from -32768 to 32767

Console.WriteLine("short_variable: {0}", short_variable);

long long_variable = 0; // "long" can contain an even larger value than "int".

Console.WriteLine("long_variable: {0}\n", long_variable);

float float_variable = 0.0f; // When using "float" make sure to add the 'f'('F') suffix after the literal otherwise the compiler will interpret the literal as a double value. "float" has a precision of '7' digits.

Console.WriteLine("float_variable: {0}", float_variable);

double double_variable = 0.0; // "double" is similar to "float", but with higher range and higher precision. "double" has a precision of '15' digits.

Console.WriteLine("double_variable: {0}", double_variable);

decimal decimal_variable = 0.0m; // "decimal" is similar to "double", but with higher range and higher precision. "decimal" has a precision of '28' digits. When using "decimal" make sure to use the 'm'('M') suffix after the literal otherwise the compiler will interpret the literal as a double value.

Console.WriteLine("decimal_variable: {0}\n", decimal_variable);

/*
Note:
1. "float" is mostly used in graphical libraries(high precessing power).
2. "double" is mainly used for real-world values.
3. "decimal" is mainly used in financial applications(high level of accuracy).
*/

bool bool_variable = false; // "bool" has two states which are "true" and "false".

Console.WriteLine("bool_variable: {0}\n", bool_variable);

char char_variable = 'a'; // "char" allows a single character literal or a Unicode.

Console.WriteLine("char_variable: {0}\n", char_variable);

string string_variable = "Ocienview Motel"; // "string" is a collection of "char".

Console.WriteLine("string_variable: {0}\n", string_variable);

// The above are some of the common data-types used.

int num_1 = 0, num_2 = 0, sum = 0; // This is how we can define and initialize multiple variables.

num_1 = 10;
num_2 = 20;

sum = num_1 + num_2;

Console.WriteLine(num_1 + " + " + num_2 + " = " + sum); // We can use the concatenation property of strings to display to the console.