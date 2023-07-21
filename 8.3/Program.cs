using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    internal class Program
    {
        static HashSet<int> set = new HashSet<int>();
        static void Main(string[] args)
        {
            while (true)
            {
                if (!set.Add(EnterNumber()))
                {
                    Console.WriteLine("Число уже существует");
                }
            }
        }
        static int EnterNumber()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
        }
    }
}
