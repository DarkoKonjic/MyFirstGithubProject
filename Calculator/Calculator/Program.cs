using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Calculator ==");

            Console.WriteLine("Operand 1:");
            int operand1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Operand 2");
            int operand2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
            Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
        }
    }
}
