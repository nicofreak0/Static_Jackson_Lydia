using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Jackson_Lydia
{
    static class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        //INTEGERS
        
        //method that adds two integers togther and returns the result
        public static int Add(int x, int y)
        {
            return x + y;
        }

        //method that subtracts two integers togther and returns the result
        public static int Sub(int x, int y)
        {
            return x - y;
        }

        //method that multiplies two integers togther and returns the result
        public static int Mult(int x, int y)
        {
            return x * y;
        }

        //method that divides two integers togther and returns the result
        public static int Div(int x, int y)
        {
            return x / y;
        }

        // FLOATERS

        //method that adds two floats togther and returns the result
        public static float Add(float x, float y)
        {
            return x + y;
        }

        //method that subtracts two floats togther and returns the result
        public static float Sub(float x, float y)
        {
            return x - y;
        }

        //method that multiplies two floats togther and returns the result
        public static float Mult(float x, float y)
        {
            return x * y;
        }

        //method that divides two floats togther and returns the result
        public static float Div(float x, float y)
        {
            return x / y;
        }
    }
}
