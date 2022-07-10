using Paranthesis;
using BalancedEqn;
using System.Collections.Generic;
Console.WriteLine("Hello, Welcome to the Cas Counter problem");
Console.WriteLine("Enter total cash money in the bank");
long CASH=Convert.ToInt64(Console.ReadLine());
CashCounter<string> counter = new CashCounter<string>(CASH);
//We will enque two people and then dequeue two people
counter.Enqueue("Abhishek");
counter.Enqueue("Raghav");
counter.Enqueue("Shubham");
counter.display();
counter.Dequeue();
counter.Dequeue();
counter.Dequeue();
counter.display();