namespace Static_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // integers
            // prints integer methods to console
            Console.WriteLine("Integer Methods");
            //prints to console the addition of two integers numbers and the sum
            Console.WriteLine("15 + 88" + Calculate.Add(15, 88));
            //prints to console the subtration of two integers numbers and the sum
            Console.WriteLine("78 - 88" + Calculate.Sub(78, 88));
            //prints to console the multiplcation of two integers numbers and the sum
            Console.WriteLine("8 x 9" + Calculate.Mult(8, 9));
            //prints to console the division of two integers numbers and the sum
            Console.WriteLine("77 / 8" + Calculate.Div(77, 8));

            //floats
            //prints float methods to console
            Console.WriteLine("Float Methods");
            //prints to console the addition of two float numbers and the sum
            Console.WriteLine("15.55f + 88.65f" + Calculate.Add(15.55f, 88.65f));
            //prints to console the subtraction of two float numbers and the sum
            Console.WriteLine("78.45f - 88.89f" + Calculate.Sub(78.45f, 88.89f));
            //prints to console the multiplication of two float numbers and the sum
            Console.WriteLine("8.99f x 9.65f" + Calculate.Mult(8.99f, 9.65f));
            //prints to console the division of two float numbers and the sum
            Console.WriteLine("77.265f 8.0f" + Calculate.Div(77.265f, 8.0f));

        }
    }
}