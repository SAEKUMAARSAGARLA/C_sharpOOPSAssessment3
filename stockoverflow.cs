using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     interface Stockover
        {
            void Push(int data);
            int Pop();
        }
    class CustomInterface_Stockover
    {
       
        public static void Main()

       {
                Stack pp = new Stack();

                pp.Push(10);
                pp.Push(27);
                pp.Push(11);
                pp.Push(19);
                pp.Push(97);
                pp.Push(99);
                pp.Push(00);

                pp.print();
            Console.WriteLine();
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

        }
    }

    public class Stack : Stockover
    {



        int[] arr = new int[6];

        int top = 0;



        public void Push(int data)

        {

            try
            {
                if (top == 6)
                {
                    Console.WriteLine("-----StackOverFlow-------");
                    
                }


                else
                {
                    arr[top] = data;
                    top++;
                }

            }
            catch (Exception e)
            {

            }
        }

        public void print()
        {

            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int Pop()
        {
            if (top <= 0)
            {
                Console.WriteLine("-----Stack Under Flow------");
                return -1;
            }
            else
            {
                int temp = arr[top - 1];
                top--;

                return temp;
            }
        }
    }



}
