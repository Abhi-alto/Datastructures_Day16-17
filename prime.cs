using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class prime
    {
        static int[,] array = new int[10,40];                       //making a 2-D array 
        public static bool check(int number)
        {
            for(int i = 2; i < number/2; i++)
            {
                if(number%i==0)
                {
                    return false;
                }
            }

            return true;
        }
        public void numArray()
        {
            int a = 1, b = 100;                                                 //will be giving the range
            for (int i = 0; i < 10; i++)                                        //since we have to make ten slots in the outer array each of 100
            {
                int index = 0;                              //represents index number of the inner array
                Console.WriteLine("Array elements in the index number "+i+" in the range "+a+"-"+b);
                for(int j=a;j<=b;j++)
                {
                    if(j==1)                                //since is neither prime nor composite
                    {
                        continue;
                    }
                    if(check(j)==true)                      //checking for prime number
                    {
                        array[i, index] = j;
                        Console.Write(j+" ");
                        index++;
                    }
                    if (j == b)                             //for changing the range of the numbers ; example- 0-100, 101-200 etc
                    {
                        a = a + 100;
                        b = b + 100;
                        break;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
