using System;

namespace _1consol
{
    internal class Program
    {
        static double f(double x)
        {
            try
            {
                if (x == -1) throw new Exception();
                else return (3*x +4) / (Math.Sqrt(x*x + 2*x +1));
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\t Начальное значение: a= ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("\n\t Конечное значение: b= ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("\n\t шаг: h= ");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine($"y({i:f2})={f(i):f4}");
                    }
                    catch
                    {
                        Console.WriteLine($"y({i})=error");
                    }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n\t****Неверный формат ввода данных****\n\n");
            }
        }
    }
}
