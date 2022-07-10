using linked;
using DataStructure;
using System.Collections.Generic;
Console.WriteLine("Hello, Welcome to the Number in a slot problem");
NumberInSlot<int> numbers = new NumberInSlot<int>();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter number "+(i+1));
    int num = Convert.ToInt16(Console.ReadLine());
    numbers.Insert(num);
}
Console.WriteLine("Enter a number you want to search");
int search=Convert.ToInt16(Console.ReadLine());
long hashcode=search.GetHashCode();
if(numbers.get(hashcode,search))
{
    numbers.remove(search,hashcode);
    Console.WriteLine("Removed " + search);
}
else
{
    Console.WriteLine("Not found");
    numbers.Insert(search);
    Console.WriteLine("Added "+search);
}
numbers.DIsplay();
