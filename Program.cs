using Datastructures;
using LinkedList;
Console.WriteLine("Hello, welcome to data structure problems");
Console.WriteLine("Enter a sentence");
string sen=Console.ReadLine();
string[] ar = sen.Split(' ');
linked_list<string> list = new linked_list<string>();
list.create(ar[0]);
for (int i = 1; i <ar.Length; i++)
{
    list.append(ar[i]);
}

Console.WriteLine("Enter a word you want to search");
string word = Console.ReadLine();
if(list.search(word)==0)                                            //returns 0 if element is not present
{
    list.append(word);
}
else
{
    list.delete(word, list.search(word));
}
list.print();