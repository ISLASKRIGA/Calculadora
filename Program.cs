﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simple");
            Console.WriteLine("------------------");

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nOperaciones:");
            Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
            if (num2 != 0)
            {
                Console.WriteLine($"División: {num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
            Console.ReadLine();
            Console.WriteLine("FDSFSDF");
            Console.WriteLine();
            //dfwd
            //hni
        }
    }
}
