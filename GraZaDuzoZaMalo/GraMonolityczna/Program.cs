﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolityczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj świecie!");

            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine($"Witaj {imie}!!!");
        }
    }
}
