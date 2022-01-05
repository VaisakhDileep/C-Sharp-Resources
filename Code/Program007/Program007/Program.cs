/*
Created by  : Vaisakh Dileep
Date        : 14, December, 2021
Description : This program helps to understand verbatim string literals in C#.
*/

string str_1 = "\aList:\n\t1. Milk\n\t2. \"Hide & Seek\"\n\t3. Juice\n"; // When using a regular string literal, we have to input everything in a single line(we can't split in multiple lines).

Console.WriteLine(str_1);

// Verbatim string will ignore the escape characters and line breaks.

// Note: When using verbatim string, add '@' before the string literal.

string str_2 = @"\aList:\n\t1. Milk\n\t2. ""Hide & Seek""\n\t3. Juice\n"; // Since the verbatim string starts and ends with '"', we have to use '""' when using '"' inside the string.

Console.WriteLine(str_2 + '\n');

// Note: We can store a string that contains tabs and new line without using escape characters in verbatim string literal.

string str_3 = @"List:
    1. Milk
    2. ""Hide & Seek""
    3. Juice"; // see here we have split the string in multiple lines and also used tabs within the string.

Console.WriteLine(str_3);

string @string = "Jesse Faden"; // Here "string" is a keyword and therefore cannot be used to name a variable, but adding '@' before the keyword will make it a valid variable name.

Console.WriteLine("@string: {0}", @string); // Use '@' before accessing the variable.