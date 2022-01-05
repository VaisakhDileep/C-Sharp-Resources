/*
Created by  : Vaisakh Dileep
Date        : 13, December, 2021
Description : This program helps to understand the string data type in C#.
*/

string string_variable = "John Hancock Center"; // "string" objects are a collection of "char" objects. Unlike C++ strings, C# strings are not terminated by the null character('\0') so we can include the null character even within the string.

// Note: When assigning literal to a string object always use double quotes("), but when assigning literal to a char object always use single quotes(').

// Note: C# strings are immutable, they cannot be changed after they are created. They can only be reassigned with a new string object.

Console.Write("string_variable: "); // "Console.Write()" won't add a new line at the end.
for(int i = 0; i < string_variable.Length; i++)
{
    Console.Write(string_variable[i]); // Since C# strings are immutable, we can only read the individual characters using the '[]' operator.
}
Console.WriteLine('\n');

Console.WriteLine("string_variable: {0}\n", string_variable);

Console.WriteLine("string_variable.Length: {0}\n", string_variable.Length);

string_variable = "one " + '\0' + "two " + "three";

Console.WriteLine("string_variable: {0}\n", string_variable); // The null character('\0') won't be displayed.

Console.WriteLine("string_variable.Length: {0}\n", string_variable.Length); // The extra length is due the null character('\0') that we inserted between "one " and "two ".

string null_string = null;

string empty_string_1 = "";
string empty_string_2 = System.String.Empty; // These are the three ways to initialize an empty string.

Console.WriteLine("null_string   : {0}", null_string);
Console.WriteLine("empty_string_1: {0}", empty_string_1);
Console.WriteLine("empty_string_2: {0}\n", empty_string_2);

// Console.WriteLine("null_string.Length: {0}", null_string.Length); // When using the "null" keyword sometimes it will throw the null reference exception error.
Console.WriteLine("empty_string_1.Length: {0}", empty_string_1.Length);
Console.WriteLine("empty_string_2.Length: {0}\n", empty_string_2.Length);

string str_1 = "Navy ";
string str_2 = "Pier";

string result = str_1 + str_2; // We can use the '+' operator to concatenate two strings.

Console.WriteLine("result: {0}", result);

Console.WriteLine();

char[] letters = {'C', 'J'};

string str_3 = new string(letters); // We can also create a string from an array of "char" elements.

Console.WriteLine("str_3: {0}\n", str_3);

string str_4 = "abcdefghijklmnopqrstuvwxyz";

Console.WriteLine("str_4                : {0}", str_4);

Console.WriteLine("str_4.Substring(1, 3): {0}", str_4.Substring(1, 3)); // "Substring()" will return the substring matched. The first argument('1') is the index of the first character to be matched, the second argument('3') is the length of the substring.

Console.WriteLine("str_4.ToUpper()      : {0}", str_4.ToUpper()); // "ToUpper()" will return a copy of the string in upper-case. The original string won't be changed.

Console.WriteLine("str_4.ToLower()      : {0}\n", str_4.ToLower()); // "ToLower()" will return a copy of the string in lower-case. The original string won't be changed.

string str_5 = "cccccccccc";

Console.WriteLine("str_5.Replace('c', '?'): {0} ", str_5.Replace('c', '?')); // "Replace()" will return a new string with all the occurrence of the first argument('c') will be replaced by the second argument('?'). The original string won't be affected.