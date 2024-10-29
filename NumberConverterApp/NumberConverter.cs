using System;

namespace NumberConverterApp
{
    public class NumberConverter
    {
        public static int ConvertFromPToDecimal(string number, int p)
        {
            if (p < 2 || p > 9)
            {
                throw new ArgumentException("Основание системы счисления должно быть в диапазоне от 2 до 9.");
            }

            int result = 0;
            int power = 1;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char digit = number[i];
                int value = digit - '0';

                if (value < 0 || value >= p)
                {
                    throw new ArgumentException($"Символ '{digit}' не является допустимым в {p}-ичной системе счисления.");
                }

                result += value * power;
                power *= p;
            }

            return result;
        }
    }
}