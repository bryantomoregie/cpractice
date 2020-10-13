using System;

namespace StarterProject 
{                         
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Cube(5));
       
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}