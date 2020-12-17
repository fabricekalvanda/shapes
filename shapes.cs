// Fabrice Kalvanda
// August 6th, 2020
// Shapes.cs
// Purpose: Methods of multiple shapes, and each shape does something different when invoqued.

using System;

namespace shapes
{
    class MainClass
    {
        /* Method for Shape */
        public static void Shape()
        {
            Console.WriteLine("I am a shape! Shapes are cool!");

            /* Printing "Shape" 5 times */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Shape");
            }
            Console.WriteLine("\n");//spiping one line after the method is done
        }

        /* Method for Rectangle */
        public static void Rectangle()
        {
            Console.WriteLine("I am a rectangle...who has 4 sides" + "\n"
                              + "I am a shape! Shapes are cool!");

            /* Printing "Shape" 5 times */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Shape");
            }
            Console.WriteLine("\n");//spiping one line after the method is done
        }

        /* Method for Triangle */
        public static void Triangle()
        {
            Console.WriteLine("I am a triangle");

            /* Printing "I have 3 sides" 3 times */
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("I have 3 sides");
            }
            Console.WriteLine("I am a shape! Shapes are cool!");

            /* Printing "Shape" 5 times */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Shape");
            }
            Console.WriteLine("\n");//spiping one line after the method is done
        }

        /* Method for Circle */
        public static void Circle()
        {
            Console.WriteLine("I am round...");

            /* Printing "I like to roll!" 7 times */
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("I like to roll!");
            }
            Console.WriteLine("I am a shape! Shapes are cool!");

            /* Printing "Shape" 5 times */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Shape");
            }
            Console.WriteLine("\n");//spiping one line after the method is done
        }
        public static void Main(string[] args)
        {
            /* Calling each method */
            Shape();
            Rectangle();
            Triangle();
            Circle();
        }
    }
}
