using static System.Console;
using Coding.Exercise;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line
            {
                End = new Point { X = 1, Y = 2 },
                Start = new Point { X = 3, Y = 4 }
            };
            Line line2 = line.DeepCopyXml();
            line2.Start = new Point { X = 4, Y = 5 };
            Console.WriteLine("Hello");
            WriteLine(line.Start.X);
            WriteLine(line2.Start.X);

        }
    }
}
