using LinkedList;
Console.WriteLine("Hello, welcome to data structure problems");
Console.WriteLine("Enter a number of numbers you want to enter");
int l=Convert.ToInt32(Console.ReadLine());
int[] ar=new int [l];
for(int i = 0; i < l; i++)
{
    Console.WriteLine("Enter element " + (i + 1));
    ar[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(ar);
linked_list<int> list = new linked_list<int>();
list.create(ar[0]);
for (int i = 1; i <ar.Length; i++)
{
    list.append(ar[i]);
}
Console.WriteLine("Enter the number you want to search");
int number = Convert.ToInt16(Console.ReadLine());
if(list.search(number)==0)                                            //returns 0 if element is not present
{
    list.append(number);
}
else
{
    list.delete(number, list.search(number));
}
list.print();