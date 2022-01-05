/*
Created by  : Vaisakh Dileep
Date        : 29, December, 2021
Description : This program helps to understand value types and reference types in C#.
*/

static void make_fifteen(int int_variable) // function that tries to change a value type.
{
    int_variable = 15;
}

static void make_american(string[] cities) // function that tries to change a reference type.
{
    cities[0] = "New York";
    cities[1] = "Chicago";
    cities[2] = "Washington DC";
}

static void display_cities(string[] cities)
{
    for(int i = 0; i < cities.Length - 1; i++)
    {
        Console.Write(cities[i] + ", ");
    }

    Console.WriteLine(cities[cities.Length - 1]);
}

// Value type: It holds the value of the variable directly on it's own memory space(value type will use the stack memory).

// egs of value type: int, float, long, char, bool, byte, decimal, double, enum, sbyte, short, struct, uint, ulong, ushort, ...etc

int int_variable_1 = 5; // Going to the definition of "int", we can see that it is internally a struct.
int int_variable_2 = int_variable_1;

int_variable_2 = 10; // Updating "int_variable_2" will not affect "int_variable_1".

Console.WriteLine("int_variable_1: {0}", int_variable_1);
Console.WriteLine("int_variable_2: {0}\n", int_variable_2);

int ten = 10;

Console.WriteLine("ten: {0}", ten);

make_fifteen(ten); // Since "int" is a value type, changes will only be applied to the copy of variable.

Console.WriteLine("ten: {0}\n", ten);

// Reference type: It holds the pointer that points to another memory location that holds the data. Reference type doesn't store the variable value directly in it's memory but instead it will store the memory address of the place where the value is stored(Reference type will use the heap memory).

// egs of reference type: string, Array, Class, Delegates, ...etc

string[] cities_1 = {"Chicago", "Mumbai", "Miami"};

string[] cities_2 = cities_1;

cities_1[1] = "Bangalore"; // Updating "cities_1" will affect "cities_2".

Console.Write("cities_1: ");
display_cities(cities_1);

Console.Write("cities_2: ");
display_cities(cities_2);
Console.Write('\n');

make_american(cities_1); // Since "string[]" is a reference type, changes will be visible to the original variable.

Console.Write("cities_1: ");
display_cities(cities_1);

Console.Write("cities_2: ");
display_cities(cities_2);