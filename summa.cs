using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число : ");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            Console.Write("Введите второе число : ");
            str = Console.ReadLine();
            int b = Convert.ToInt32(str);
            a = a + b;
            Console.Write("Сумма : ");
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
