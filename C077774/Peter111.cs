using System;

namespace C077774
{
    class Peter111
    {
        static int i = 0;

        static void Main(string[] args)
        {   MethodA();
            Console.WriteLine("Now I am done!!!");
        }

        public static void MethodA()
        {
            while (Peanut())
            {
                Console.WriteLine(" i is {0} ", i);
                if (i> 10)
                    {   // SDDDD
                        return;
                    }
            }
        }

        public static bool Peanut()
        {
            i++;
            return true;
        }
    }
}
