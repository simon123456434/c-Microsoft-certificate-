// See https://aka.ms/new-console-template for more information
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
