using System;

namespace MultipleIfStatement
{
   internal class Program
   {
      static void Main()
      {
         // 1. Независимые условия (все условия проверяются)
         int numberOne = 5;

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

         // 2. Взаимоисключающие условия (выполняется только первый истинный блок)
         int numberTwo = 8;

         if (numberTwo!= 0)
         {
            // Действие, если условие1 истинно
            Console.WriteLine("Число не равно 0");
         }
         else if (numberTwo)
         {
            // Действие, если условие2 истинно (проверяется только если условие1 ложно)
         }
         else if (numberTwo)
         {
            // Действие, если условие3 истинно (проверяется только если условие1 и условие2 ложны)
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
