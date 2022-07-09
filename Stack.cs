using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paranthesis;

namespace BalancedEqn
{
    internal class Stackk<gtype>where gtype : IComparable
    {
        Node<gtype> top;
        public Stackk()
        {
            this.top = null;
        }
        public void push(gtype pushNode)
        {
            Node<gtype> node = new Node<gtype>(pushNode);
            if (top == null)
            {
                node.next = null; ;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Pushed nodewith data " + node.data);
        }
        public void pop()                   //single node is poped
        {
            Node<gtype> temp = top;
            if (top != null)
            {
                Console.WriteLine("Data of the poped node is " + temp.data);
                top = temp.next;
            }
            else
                Console.WriteLine("Stack is empty");
        }
        public void fullpop()                       //pop function till the statck is empty
        {
            while (top != null)
            {
                Node<gtype> temp = top;
                Console.WriteLine("Data of the poped node is " + top.data);
                top = temp.next;
            }
            Console.WriteLine("Stack is empty");
        }
        public void peek()                  //gives the top most node data without popping it
        {
            if (this.top != null)
            {
                Console.WriteLine("top element is " + top.data);
            }
            else
                Console.WriteLine("Stack is empty");
        }
        public bool empty()                 //To check if the stackis empty
        {
            if (this.top == null)
            {
                //Console.WriteLine("Stack is empty");
                return true;
            }
            else
            {
                return false;
                Console.WriteLine("Stack is not empty");
            }
        }
        public void print()
        {
            Node<gtype> temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
