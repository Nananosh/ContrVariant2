using System;

namespace ContrVariant2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stool stool = new Stool(10, Quality.High);
            Chair chair = new Chair(15, Quality.High, 5);
            Console.WriteLine(stool.ToString());
            Console.WriteLine(chair.ToString());
        }
    }
}