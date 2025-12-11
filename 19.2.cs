using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string a = "";
            while (true)
            {
                a = Console.ReadLine();
                if (a == "")
                {
                    break;
                } else
                {
                    stack.Push(a);
                }
            }
            Console.WriteLine("Вывод в обратном порядке:");
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
        }
    }
}
