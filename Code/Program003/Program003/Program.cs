/*
Created by  : Vaisakh Dileep
Date        : 25, November, 2021
Description : This program helps to understand the integral numeric type in C#.
*/

sbyte sbyte_variable = 0; // Signed 8-bit integer.

byte byte_variable = 0; // Unsigned 8-bit integer.

short short_variable = 0; // Signed 16-bit integer.

ushort ushort_variable = 0; // Unsigned 16-bit integer.

int int_variable = 0; // Signed 32-bit integer.

uint uint_variable = 0; // Unsigned 32-bit integer.

long long_variable = 0; // Signed 64-bit integer.

ulong ulong_variable = 0; // Unsigned 64-bit integer.

nint nint_variable = 0; // This signed integral numeric type depends on the platform.

nuint nuint_variable = 0; // This unsigned integral numeric type depends on the platform.

// "nint" and "unint" are native-sized integers. They can be a 32-bit integer when running on a 32-bit process and 64-bit integer when running on 64-bit process.

Console.WriteLine("sizeof(sbyte) : {0}", sizeof(sbyte));
Console.WriteLine("sizeof(byte)  : {0}", sizeof(byte));
Console.WriteLine("sizeof(short) : {0}", sizeof(short));
Console.WriteLine("sizeof(ushort): {0}", sizeof(ushort));
Console.WriteLine("sizeof(int)   : {0}", sizeof(int));
Console.WriteLine("sizeof(uint)  : {0}", sizeof(uint));
Console.WriteLine("sizeof(long)  : {0}", sizeof(long));
Console.WriteLine("sizeof(ulong) : {0}", sizeof(ulong));

unsafe // In order to get the size of "nint" and "nuint", we need to use it inside the "unsafe" block.
{
    Console.WriteLine("sizeof(nint) : {0}", sizeof(nint));
    Console.WriteLine("sizeof(nuint): {0}\n", sizeof(nuint));
}

Console.WriteLine("sbyte : [{0}, {1}]", sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("byte  : [{0}, {1}]", byte.MinValue, byte.MaxValue);
Console.WriteLine("short : [{0}, {1}]", short.MinValue, short.MaxValue);
Console.WriteLine("ushort: [{0}, {1}]", ushort.MinValue, ushort.MaxValue);
Console.WriteLine("int   : [{0}, {1}]", int.MinValue, int.MaxValue);
Console.WriteLine("uint  : [{0}, {1}]", uint.MinValue, uint.MaxValue);
Console.WriteLine("long  : [{0}, {1}]", long.MinValue, long.MaxValue);
Console.WriteLine("ulong : [{0}, {1}]", ulong.MinValue, ulong.MaxValue);
Console.WriteLine("nint  : [{0}, {1}]", nint.MinValue, nint.MaxValue);
Console.WriteLine("nuint : [{0}, {1}]\n", nuint.MinValue, nuint.MaxValue);

sbyte_variable = 10;
byte_variable = 20;

short_variable = 100;
ushort_variable = 200;

int_variable = 1_000; // We can use '_' to separate digits for better readability.
uint_variable = 2_000;

long_variable = 10_000;
ulong_variable = 20_000;

nint_variable = 100_000;
nuint_variable = 200_000;

uint_variable = 8_000U; // We could also use 'u' as suffix. Adding 'U' as suffix will only make the literal map to "uint" and "ulong".
ulong_variable = 7_000U;

long_variable = 5_000L; // We could also use 'l' as suffix. Adding 'L' as suffix will only make the literal map to "long" and "ulong".
ulong_variable = 4_000L;

ulong_variable = 900_000UL; // We could also use 'Ul', 'uL', 'ul', 'LU', 'Lu', 'lU', 'lu' as suffix. Adding 'UL' as suffix will only make the literal map to "ulong".

int_variable = 0B111011; // We could also use '0b' as prefix. Adding '0B' as prefix will allow us to represent the literal in binary form.

Console.WriteLine("int_variable: {0}", int_variable);

int_variable = 0XFF; // We could use also '0x' as prefix. Adding '0x' as prefix will allow us to represent the literal in hexadecimal form.

Console.WriteLine("int_variable: {0}\n", int_variable);

int_variable = -1;

Console.WriteLine("-1(in hexadecimal): {0:X}", int_variable); // Note that for '-1' all bits are set. This is how we print in hexadecimal format.
Console.WriteLine("-1(in hexadecimal): {0:x}\n", int_variable); // lower-case equivalent for the above. Use 'X' for upper-case representation and 'x' for lower-case representation.

int_variable = unchecked((int)0XFFFF_FFFF); // "0XFFFF_FFFF" is of "uint" type, so we need to explicitly convert to "int". Explicitly converting might result in an overflow so we have to use the "unchecked" function.

Console.WriteLine("int_variable: {0}", int_variable);

uint_variable = 0XFFFF_FFFF; // "0XFFFF_FFFF" is of "uint" type, so we don't need to convert here.

Console.WriteLine("uint_variable: {0}", uint_variable);