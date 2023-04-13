using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Class_A
    {
        
            public int a;
            public int b;


            public void Multiply()
            {
                Console.Write("Введите a и b: ");
                int.Parse(Console.ReadLine());
                int.Parse(Console.ReadLine());
                int mult = a * b;
                Console.WriteLine($"Произведение {a} на {b} = {mult}");
            }


        }
    }
