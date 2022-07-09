using Paranthesis;
using BalancedEqn;
using System.Collections.Generic;
Console.WriteLine("Hello, welcome to data structure problems");
Console.WriteLine("Enter an equation");
String equation=Console.ReadLine();
char[] ar=equation.ToCharArray();
Stackk<char> bracket=new Stackk<char>();
int flag = 0;                                            //for checking the last condition if the stack has become empty at last or just in the middle  
for(int i=0; i<ar.Length; i++)
{
    if (ar[i] == '('|| ar[i] == '{'|| ar[i] == '[')         //pushing 
    {
        bracket.push(equation[i]);
    }
    else if (ar[i] == ')'|| ar[i] == '}'|| ar[i] == ']')            //poping
    {
        ///checking if the stack becomes empty in between
        if (bracket.empty())                
        {
            Console.WriteLine("Stack is empty");
            flag++;
            break;
        }
            bracket.pop();
    }
    else
        continue;
}
if (bracket.empty()&&flag==0)
    Console.WriteLine("Balanced equation");
else
    Console.WriteLine("Unbalanced equation");