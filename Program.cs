﻿namespace Static_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // integers
            Console.WriteLine(Calculate.Add(15, 88));
            Console.WriteLine(Calculate.Sub(78, 88));
            Console.WriteLine(Calculate.Mult(8, 9));
            Console.WriteLine(Calculate.Div(77, 8));

            //floats
            Console.WriteLine(Calculate.Add(15.55f, 88.65f));
            Console.WriteLine(Calculate.Sub(78.45f, 88.89f));
            Console.WriteLine(Calculate.Mult(8.99f, 9.65f));
            Console.WriteLine(Calculate.Div(77.265f, 8.0f));

        }
    }
}