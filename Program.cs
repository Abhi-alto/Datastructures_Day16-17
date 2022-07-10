using DataStructure;
using System.Collections.Generic;
Console.WriteLine("Hello, Welcome to the Palindrome Checker");
Console.WriteLine("Enter a word");
string word=Console.ReadLine();
char[] ch = word.ToCharArray();
PalindromeChecker<char> counter = new PalindromeChecker<char>();
String reverse = "";
for (int x = word.Length-1; x >=0; x--)                 //enquing every letter of the string from the back
{
    counter.Enqueue(ch[x]);
}
for (int x=0;x<word.Length;x++)                     //dequeuing and storing every character in a string
{
    reverse = reverse + counter.Dequeue();
}
if (word.CompareTo(reverse) == 0)
    Console.WriteLine("Palindrome word");
else
    Console.WriteLine("Not a palindrome word");