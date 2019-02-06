using System;

namespace C077774
{
    class Peter111
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        public static void MethodA()
        {
            while (Peanut())
            {
                Console.WriteLine("Help ! I am stuck in an infinite loop!");
            }
        }

        public static bool Peanut()
        {
            return true;
        }
    }
}
