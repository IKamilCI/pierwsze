﻿using System;
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
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");
                Console.WriteLine("5. Exit");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 5)
                    break;
                int a = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
