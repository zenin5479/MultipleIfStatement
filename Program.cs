using System;

namespace MultipleIfStatement
{
   internal class Program
   {
      static void Main()
      {
         // 1. Независимые условия (все условия проверяются)
         int numberOne = 5;
         // условие 1
         if (numberOne < 10)
         {
            // Действие, если условие 1 истинно
            Console.WriteLine("Число меньше 10");
         }
         // условие 2
         if (numberOne > 0)
         {
            // Действие, если условие 2 истинно
            Console.WriteLine("Число положительное");
         }
         // условие 3
         if (numberOne == 5)
         {
            // Действие, если условие 3 истинно
            Console.WriteLine("Число равно 5");
         }

         // 2. Взаимоисключающие условия (выполняется только первый истинный блок)
         int numberTwo = 8;
         // условие 1
         if (numberTwo == 0)
         {
            // Действие, если условие 1 истинно
            Console.WriteLine("Число равно 0");
         }
         // условие 2
         else if (numberTwo < 3)
         {
            // Действие, если условие 2 истинно (проверяется только если условие 1 ложно)
            Console.WriteLine("Число меньше 3");
         }
         // условие 3
         else if (numberTwo < 10)
         {
            // Действие, если условие 3 истинно (проверяется только если условие 1 и условие 2 ложны)
            Console.WriteLine("Число меньше 10");
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
