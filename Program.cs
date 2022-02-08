using System;

namespace Return_value
{
    class Program
    {
        static double Remainder(int x, int y)

        {
            return x % y;

        }
        static void Main(String[] args)
        {
            Console.WriteLine(Remainder(5, 9));
        }
            
        
    }
}
