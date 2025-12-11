using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            Queue<string> queue = new Queue<string>();
            string a = "";
            while (true)
            {
                a = Console.ReadLine();
                if (a == "")
                {
                    break;
                }else
                {
                    queue.Enqueue(a);
                }
                if (queue.Count > 3)
                {
                    string oldest = queue.Dequeue();
                    dic.Remove(oldest);
                }
            }
            Console.Write("Текущий кеш: ");
            foreach (string s in queue)
            {
                Console.Write(s + ", ");
            }
        }
    }
}
