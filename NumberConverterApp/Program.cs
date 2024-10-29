using System;

namespace NumberConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в p-ичной системе счисления:");
            string number = Console.ReadLine();

            Console.WriteLine("Введите основание системы счисления (от 2 до 9):");
            int p = int.Parse(Console.ReadLine());

            try
            {
                int result = NumberConverter.ConvertFromPToDecimal(number, p);
                Console.WriteLine($"Число {number} в {p}-ичной системе равно {result} в десятичной системе.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}