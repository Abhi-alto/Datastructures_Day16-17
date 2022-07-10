using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paranthesis;

namespace BalancedEqn
{
    public class CashCounter<gtype> 
    {
        long BankCash;
        Node<gtype> rear;
        Node<gtype> front;
        public CashCounter(long BankCash)
        {
            this.BankCash = BankCash;
            this.rear = null;
            this.front = null;
        }
        public void Enqueue(gtype AddToQueue)         //for adding persons in the queue
        {
            Node<gtype> node = new Node<gtype>(AddToQueue);
            if (front == null)
            {
                rear = node;
                front = rear;
                Console.WriteLine("Added the person " + rear.data + " to the queue");
            }
            else
            {
                rear.next = node;
                rear = rear.next;
                Console.WriteLine("Added the person " + rear.data + " to the queue");
            }
        }
        public void Dequeue()                       //for removing nodes one by one from the queue
        {
            if (rear == null && front == null)
            {
                Console.WriteLine("No one is left");
            }
            else
            {
                Console.WriteLine("Choose 1- for withdrawing cash and 2- for depositing money");
                int ch = Convert.ToInt16(Console.ReadLine());
                if(ch ==1)
                {
                    Console.WriteLine("Enter how much money you want to withdraw");
                    long transaction = Convert.ToInt64(Console.ReadLine());
                    if (transaction <= BankCash)
                    {
                        BankCash = BankCash - transaction;
                    }
                    else
                        Console.WriteLine("Inadequate money in the bank");
                }
                else if(ch==2)
                {
                    Console.WriteLine("Enter how much money you want to deposit");
                    long transaction = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Taken out " + front.data + " from the que");
                front = front.next;
            }
        }
        public void DequeueTotal()                       //for removing all the persons from the queue 
        {
            if (rear == null && front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while (front != null)
                {
                    Console.WriteLine("Taken out " + front.data + " from the que");
                    front = front.next;
                }
            }
        }
        public void display()                       //Displaying the node of the queue
        {
            if (rear == null && front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node<gtype> temp = front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
                Console.WriteLine("Cash left in the bank  = "+BankCash);
            }
        }
    }
}
