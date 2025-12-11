using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string a = "";
            while (true)
            {
                a = Console.ReadLine();
                if (a == "")
                {
                    break;
                }
                else
                {
                    set.Add(a);
                }
            }
            var sort = set.OrderBy(x => x).ToArray();
            Console.Write("Уникальные: ");
            foreach (string s in sort)
            {
                Console.Write(s + ", ");
            }
        }
    }
}
