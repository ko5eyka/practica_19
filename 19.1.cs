
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Анна");
            queue.Enqueue("Пётр");
            queue.Enqueue("Ольга");
            queue.Enqueue("Иван");
            queue.Enqueue("Мария");
            Console.Write("Очередь: ");
            foreach (string a  in queue)
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine();
            foreach (string b in queue)
            {
                Console.WriteLine("Обслуживаем: " + b);
            }
            Console.WriteLine("Очередь пуста.");
        }
    }
}
