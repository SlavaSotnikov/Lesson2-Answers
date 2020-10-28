using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Converter converter = new Converter(8.56, 10.14, 0.12);
           
            converter.ToUsd(100);
            converter.FromUsd(100);

            Console.ReadKey();
        }
    }
}
