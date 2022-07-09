using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
    public class Node<gtype>
    {
        public gtype data;
        public Node<gtype> next;
        public Node(gtype data)
        {
            this.data = data;
        }
    }
}
