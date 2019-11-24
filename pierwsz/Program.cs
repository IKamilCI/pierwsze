using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwsz
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int menuOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("4. /");
                Console.WriteLine("5. Exit");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. *");
                int a = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
