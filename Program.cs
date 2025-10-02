using System;

namespace MultipleIfStatement
{
   internal class Program
   {
      static void Main()
      {
         // 1. Независимые условия (все условия проверяются)
         Console.WriteLine("Независимые условия (все условия проверяются)");
         int numberOne = EnterSetValue();
         // условие 1
         if (numberOne > -100)
         {
            // Действие, если условие 1 истинно
            Console.WriteLine("Проверка условия 1: число < -100");
            Console.WriteLine("Истинно");
         }
         // условие 2
         if (numberOne < 100)
         {
            // Действие, если условие 2 истинно
            Console.WriteLine("Проверка условия 2: число < 100");
            Console.WriteLine("Истинно");
         }
         // условие 3
         if (numberOne != 0)
         {
            // Действие, если условие 3 истинно
            Console.WriteLine("Проверка условия 3: число != 0");
            Console.WriteLine("Истинно");
         }

         // 2. Взаимоисключающие условия (выполняется только первый истинный блок)
         Console.WriteLine("Взаимоисключающие условия (выполняется только первый истинный блок)");

         int numberTwo = EnterSetValue();
         // условие 1
         if (numberTwo < -100)
         {
            // Действие, если условие 1 истинно
            Console.WriteLine("Проверка условия 1: число < -100");
            Console.WriteLine("Истинно");
         }
         // условие 2
         else if (numberTwo > 100)
         {
            // Действие, если условие 2 истинно (проверяется только если условие 1 ложно)
            Console.WriteLine("Проверка условия 2: число > -100");
            Console.WriteLine("Истинно");
         }
         // условие 3
         else if (numberTwo != 0)
         {
            // Действие, если условие 3 истинно (проверяется только если условие 1 и условие 2 ложны)
            Console.WriteLine("Проверка условия 3: число != 0");
            Console.WriteLine("Истинно");
         }

         // 3.Комбинированный вариант (с добавлением else)
         Console.WriteLine("Комбинированный вариант (с добавлением else)");
         int numberThree = EnterSetValue();
         // условие 1
         if (numberThree > 100)
         {
            // Действие, если условие 1 истинно
            Console.WriteLine("Проверка условия 1: число > 100");
            Console.WriteLine("Истинно");
         }
         // условие 2
         else if (numberThree < -100)
         {
            // Действие, если условие 2 истинно (проверяется только если условие 1 ложно)
            Console.WriteLine("Проверка условия 2: число < -100");
            Console.WriteLine("Истинно");
         }
         // условие 3
         else if (numberThree == 0)
         {
            // Действие 3
            Console.WriteLine("Проверка условия 3: число == 0");
            Console.WriteLine("Истинно");
         }
         else
         {
            // Действие, если все условия ложны
            Console.WriteLine("Проверка условия 4: число > -100, < 100, !=0");
            Console.WriteLine("Истинно");
         }

         Console.ReadKey();
      }

      public static int EnterSetValue()
      {
         int n;
         do
         {
            Console.WriteLine("Введите число:");
            int.TryParse(Console.ReadLine(), out n);
            //n = Convert.ToInt32(Console.ReadLine());
            if (n <= -100 || n >= 100)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (n <= -100 || n >= 100);

         return n;
      }
   }
}