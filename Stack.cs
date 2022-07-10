using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class PalindromeChecker<gtype> 
    {
        Node<gtype> rear;
        Node<gtype> front;
        public PalindromeChecker()
        {
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
            }
            else
            {
                rear.next = node;
                rear = rear.next;
            }
        }
        public gtype Dequeue()                       //for removing nodes one by one from the queue
        {
            gtype character= front.data;
                front = front.next;
            return character;
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
                //Console.WriteLine("Cash left in the bank  = "+BankCash);
            }
        }
    }
}
