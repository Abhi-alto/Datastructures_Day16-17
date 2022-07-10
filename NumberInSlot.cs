using linked;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class NumberInSlot<gtype> where gtype:IComparable
    { 
        linked_list<gtype>[] key_row = new linked_list<gtype>[11];    //array of linked list type data type with size 11
        public NumberInSlot()
        {
            for (int x = 0; x < 11; x++)                               //taking the predefined size of array as 11
            {
                linked_list<gtype> list = new linked_list<gtype>();
                key_row[x] = list;
            }
        }
        public void Insert(gtype data)          //inserting a data into  hash table
        {
            long hashcode = data.GetHashCode();
            long index = Math.Abs(hashcode % 11);
            linked_list<gtype> temporary;
            temporary = key_row[index];
            temporary.add(data);
        }
        public bool get(long key,gtype number)        //using the entered key we find if the key is present in the hash table & and then print it
        {
            long hashcode = key % 11;
            if (hashcode <= 10)
            {
                linked_list<gtype> temp;
                temp = key_row[key % 11];
                if(temp.search(number)==0)
                {   return false; }
                else
                    { return true; 
                }
            }
            else
            {
                Console.WriteLine("kEY NOT PRESENT IN THE HASH TABLE");
                return false;
            }

        }
        public void remove(gtype data, long hashcode)             //removing a data from the hash table
        {
            linked_list<gtype> temp;
            temp = key_row[hashcode % 11];
            Console.WriteLine("Linked List has ");
            temp.print();
            int index = temp.search(data);
            temp.delete(data, index);
            Console.WriteLine("After deleting , linked list has ");
            temp.print();
        }
        public int getsize()                                //getting the size of the hash table
        {
            int size = 0;
            for (int x = 0; x < 11; x++)
            {
                linked_list<gtype> temp;
                temp = key_row[x];
                size = size + temp.size();
            }
            Console.WriteLine(size + " is the size of the hash table");
            return size;
        }
        public void frequencyOfword(long hashcode, gtype wordFreq)
        {
            ///for getting the frequency, we first go that particular 
            ///linked list using the hash code and then call the frequency function for that linked list
            linked_list<gtype> temp;
            temp = key_row[hashcode % 11];
            Console.WriteLine("frequency of " + wordFreq + " is " + temp.frequency(wordFreq));
        }
        public bool isEmpty()                       //checking if the hash table is empty or not
        {
            NumberInSlot<gtype> obj = new NumberInSlot<gtype>();
            if (obj.getsize() > 0)
                return false;
            else
                return true;
        }
        public void DIsplay()
        {
            for(int i=0;i<11;i++)
            {
                linked_list<gtype> temporary;
                temporary = key_row[i];
                temporary.print();
                Console.WriteLine();
            }    
        }

    }
}
