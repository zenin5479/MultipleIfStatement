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
         if (numberOne < 10)
         {
            // Действие, если условие 1 истинно
            Console.WriteLine("Действие, если условие 1 истинно: число < 10");
            Console.WriteLine("Число меньше 10");
         }
         // условие 2
         if (numberOne > 0)
         {
            // Действие, если условие 2 истинно
            Console.WriteLine("Действие, если условие 2 истинно: число > 0");
            Console.WriteLine("Число положительное");
         }
         // условие 3
         if (numberOne == 5)
         {
            // Действие, если условие 3 истинно
            Console.WriteLine("Действие, если условие 3 истинно: число == 5");
            Console.WriteLine("Число равно 5");
         }

         // 2. Взаимоисключающие условия (выполняется только первый истинный блок)
         Console.WriteLine("Взаимоисключающие условия (выполняется только первый истинный блок)");

         int numberTwo = EnterSetValue(); ;
         // условие 1
         if (numberTwo == 0)
         {
            // Действие, если условие 1 истинно
            Console.WriteLine("Действие, если условие 1 истинно: число == 0");
            Console.WriteLine("Число равно 0");
         }
         // условие 2
         else if (numberTwo < 3)
         {
            // Действие, если условие 2 истинно (проверяется только если условие 1 ложно)
            Console.WriteLine("Действие, если условие 2 истинно (проверяется только если условие 1 ложно): число < 3");
            Console.WriteLine("Число меньше 3");
         }
         // условие 3
         else if (numberTwo < 10)
         {
            // Действие, если условие 3 истинно (проверяется только если условие 1 и условие 2 ложны)
            Console.WriteLine("Действие, если условие 2 истинно: число < 3");
            Console.WriteLine("Число меньше 10");
         }

         // 3.Комбинированный вариант (с добавлением else)
         Console.WriteLine("Комбинированный вариант (с добавлением else)");
         int numberThree = EnterSetValue(); ;
         // условие 1
         if (numberThree == 0)
         {
            // Действие 1
            Console.WriteLine("Число равно 0");
         }
         // условие 2
         else if (numberThree == 3)
         {
            // Действие 2
            Console.WriteLine("Число равно 3");
         }
         // условие 3
         else if (numberThree == 5)
         {
            // Действие 3
            Console.WriteLine("Число равно 5");
         }
         else
         {
            // Действие, если все условия ложны
            Console.WriteLine("Число не равно: 0, 3, 5");
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