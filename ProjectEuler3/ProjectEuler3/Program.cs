using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler3
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 600851475143;

            //Start with the smallest prime number
            while(x % 2 == 0)
            {
                Console.Write("2 ");

                x = x / 2;
            }

            //Working our way up on the prime list
            for(int i = 3; i <= Math.Sqrt(x); i += 2)
            {
                while(x % i == 0)
                {
                    Console.Write(i + " ");

                    x = x / i;
                }
            }

            //Handling output if last prime is larger than two
            if(x > 2)
            {
                Console.Write(x);
            }

            Console.ReadLine();
        }
    }
}
