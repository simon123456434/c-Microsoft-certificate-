// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.ComponentModel;





using System;
using System.Reflection;
using Microsoft.VisualBasic;




// 
string brown  = "The quick brown fox jumps over the lazy dog.";





// convert the message into a char array
char[] charMessage = brown.ToCharArray();


// Reverse the chars
Array.Reverse(charMessage);
int x = 0;


// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }


// convert it back to a string
string new_message = new String(charMessage);



// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
