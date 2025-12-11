using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            string a = "";
            while (true)
            {
                a = Console.ReadLine();
                if (a == "")
                {
                    break;
                }
                else if (a == "Back")
                {
                    if (list.Count >= 1)
                    {
                        list.RemoveLast();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    list.AddLast(a);
                }
            }
            Console.WriteLine("Текущая страница: " + list.Last.Value);
        }
    }
}
