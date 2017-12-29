using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _3sem_1lab
{
    class Program
    {
        static void Main(string[] args)
        {
            float f;
            Console.Write("Введите число ");
            string str = Console.ReadLine();
            Console.WriteLine("Преобразование строки в число...");
            try
            {
                f = float.Parse(str);
                Console.WriteLine("Вы ввели число " + f.ToString("F5"));
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число" + e.Message);
                Console.WriteLine("\nПодробное описание ошибки: " + e.StackTrace);
            }
            CommandLineArgs(args);
            Console.WriteLine("-------------------------------------------------------------");
            double a = ReadDouble("Введите коэффициент a: ");
            Console.WriteLine("Вы ввели коэффициет a = " + a);
            Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------");
            double b = ReadDouble("Введите коэффициент b: ");
            Console.WriteLine("Вы ввели коэффициет b = " + b);
            Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------");
            double c = ReadDouble("Введите коэффициент c: ");
            Console.WriteLine("Вы ввели коэффициет c = " + c);
            Console.ReadLine();
            double d = b * b - 4 * a * c;
            double x1=(-b+Math.Sqrt(d))/2, x2=(-b-Math.Sqrt(d))/2;
            Console.Write("Корни уравнения: " + x1 + ", " + x2);
            Console.ReadLine();
        }

        static void CommandLineArgs(string[] args)
        {
            Console.WriteLine("\nВывод параметров командноей строки");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Параметр[{0}] = {1}", i, args[i]);
            }
        }

        static double ReadDouble(string message)
        {
            string resultString;
            double resultDouble;
            bool flag;

            do
            {
                Console.Write(message);
                resultString = Console.ReadLine();

                try
                {
                    resultDouble = double.Parse(resultString);
                    flag = true;
                }
                catch
                {
                    resultDouble = 0;
                    flag = false;
                }
                if (!flag)
                {
                    Console.WriteLine("Необходимо ввести вещественное число");
                }
            }
            while (!flag);
            return resultDouble;
        }
    }
}

