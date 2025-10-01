using System;

namespace MultipleIfStatement
{
   internal class Program
   {
      static void Main()
      {
         // 1. Независимые условия (все условия проверяются)
         int numberOne = 1;

         if (numberOne < 0)
         {
            // Действие, если условие1 истинно
            Console.WriteLine("Число отрицательное");
         }
         if (numberOne > 0)
         {
            // Действие, если условие2 истинно
            Console.WriteLine("Число положительное");
         }
         if (numberOne == 5)
         {
            // Действие, если условие3 истинно
            Console.WriteLine("Число равно 5");
         }

         int number = 10;

         if (number > 0)
         {
            Console.WriteLine("Число положительное");
         }
         else if (number < 0)
         {
            Console.WriteLine("Число отрицательное");
         }
         else
         {
            Console.WriteLine("Число равно нулю");
         }
      }
   }
}
