using SQlibrary.factory;
using SQlibrary.interfaces;
using SQlibrary.models;
using System;

namespace SQconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            iIOmethod ioMethod = new ConsoleIO();

            Console.WriteLine("1. Circle");
            iFigureFactory factory = new CircleFactory(ioMethod);
            iFigure fig = factory.create();
            Console.WriteLine("Circle square = " + fig.getSquare());

            Console.WriteLine("2. Triangle");
            factory = new TriangleFactory(ioMethod);
            fig = factory.create();
            Console.WriteLine("Triangle square = " + fig.getSquare());
            Triangle triangle = fig as Triangle;
            if (triangle != null)
            {
                Console.WriteLine("Is this a right triangle? " + (triangle.isRightAngle() ? "Yes!!" : "No!"));
            }
            

            Console.WriteLine();
            Console.WriteLine("Happy end! Press a key..");
            Console.ReadKey();
        }
    }
}
