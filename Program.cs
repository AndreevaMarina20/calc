using System.Runtime.InteropServices;

namespace Calculator
{
    class Programm
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
             double num, num1;
             string action;
             Console.WriteLine("Введите первое число:");
             num = double.Parse(Console.ReadLine());
             Console.WriteLine("Выберите операцию:");
             action = Console.ReadLine();
             Console.WriteLine("Введите второе число:");
             num1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Результат:");
             switch (action)
             {
              case "+":
              Console.WriteLine(num + num1);
              break;
              case "-":
              Console.WriteLine(num - num1);
              break;
              case "*":
              Console.WriteLine(num * num1);
              break;
              case "/":
              if (num1 == 0)
             {
                Console.WriteLine(0);
             }
              else
             {
                Console.WriteLine(num / num1);
             }
              break;
              case "%":
              Console.WriteLine(num % num1);
              break;
              default:
                Console.WriteLine("Неизвестное действие");
              break;
         }
           Console.ReadLine();
            }
           
        }
    }
}