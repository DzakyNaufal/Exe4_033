using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_033
{
    class Node
    {
        
        public int info;
        public Node next;
        

        public Node (int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        private int[] dzaky = new int [51];
        private int n;
        Node top;
       
        public Stacks()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {

            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed.");

            void input()
            {
                while (true)
                {
                    Console.Write("Enter a number: ");
                    string s = Console.ReadLine();
                    n = Int32.Parse(s);
                    if (n <= 51)
                        break;
                    else
                        Console.WriteLine("\nThe maximun number of data is 55 elements \n");
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + ">");
                    string s1 = Console.ReadLine();
                    dzaky[i] = Int32.Parse(s1);
                }
            }
        }

        public void pop()
        {
            Console.WriteLine("\nThe popped elements is: " + top.info);
            top = top.next; 
        }

        public void display()
        {
            Node tmp;

            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("\nEnter a number: ");                     
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choise");
                        break;
                }
            }
        }
    }
}
