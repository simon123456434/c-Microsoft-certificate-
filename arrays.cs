// See https://aka.ms/new-console-template for more information In C#, arrays are a fundamental data structure that allows you to store a fixed-size sequence of elements of the same type. Here’s a detailed explanation of arrays in C#:

### 1. **Declaration and Initialization**
You can declare and initialize an array in C# using the following syntax:

```csharp
// Declaration
int[] numbers; // Declares an array of integers

// Initialization
numbers = new int[5]; // Creates an array with 5 elements

// Declaration and Initialization in one line
int[] moreNumbers = new int[] { 1, 2, 3, 4, 5 }; // Initializes with values
```

### 2. **Accessing Elements**
You can access elements in an array using their index, which starts at 0:

```csharp
int firstNumber = moreNumbers[0]; // Accesses the first element (1)
```

### 3. **Modifying Elements**
You can modify elements in an array by assigning a new value to a specific index:

```csharp
moreNumbers[2] = 10; // Changes the third element from 3 to 10
```

### 4. **Array Length**
You can get the length of an array using the `Length` property:

```csharp
int length = moreNumbers.Length; // Gets the number of elements in the array
```

### 5. **Iterating Through an Array**
You can use a `for` loop or a `foreach` loop to iterate through the elements of an array:

```csharp
// Using a for loop
for (int i = 0; i < moreNumbers.Length; i++)
{
    Console.WriteLine(moreNumbers[i]);
}

// Using a foreach loop
foreach (int number in moreNumbers)
{
    Console.WriteLine(number);
}
```

### 6. **Multidimensional Arrays**
C# also supports multidimensional arrays, such as two-dimensional arrays:

```csharp
// Declaration and initialization of a 2D array
int[,] matrix = new int[3, 3]; // 3x3 matrix

// Assigning values
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;

// Accessing a value
int value = matrix[0, 1]; // Gets the value 2
```

### 7. **Jagged Arrays**
C# allows jagged arrays, which are arrays of arrays. Each "inner" array can have a different length:

```csharp
// Declaration and initialization of a jagged array
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[3] { 3, 4, 5 };
jaggedArray[2] = new int[1] { 6 };

// Accessing a value
int jaggedValue = jaggedArray[1][2]; // Gets the value 5
```

### Summary
Arrays in C# are a powerful way to store and manipulate collections of data. They provide efficient access to elements and are essential for many programming tasks. However, since their size is fixed, if you need a resizable collection, you might consider using other data structures like `List<T>`.
using System.Collections.Generic;
using System.ComponentModel;





using System;
using System.Reflection;
using Microsoft.VisualBasic;




using System;
using System.Xml;



using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // Define XmlOutputMethod as a dynamic list to store the results
        List<string> XmlOutputMethod = new List<string>();

        // Original investigation array
        string[] investigation = { "  B123  ", "A345", "C15", " B177 ", " G3003  ", " C235 ", " B179 " };

        // Loop through each item in the investigation array
        foreach (string item in investigation)
        {
            // Check if the trimmed item starts with "B"
            if (item.Trim().StartsWith("B"))
            {
                XmlOutputMethod.Add(item.Trim()); // Add the item to XmlOutputMethod
            }
        }

        // Print the filtered results
        foreach (string result in XmlOutputMethod)
        {
            Console.WriteLine( $"This is to be investigated  {result}"  );
        }
    }
}
