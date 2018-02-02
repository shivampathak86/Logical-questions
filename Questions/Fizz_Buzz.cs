using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Fizz_Buzz
    {


        public void Print_Fizz_Buzz()
        {
            int ArrayLenght = int.Parse(Console.ReadLine());

            int[] input = new int[ArrayLenght];
            string [] ch =  Console.ReadLine().Split(' ');
            for( int i=0;i<ch.Length;i++)
            {
                input[i] = int.Parse(ch[i]);
            }

            

            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (input[j] % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (input[j] % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(j);
                }
                
            }
            Console.Read();


        }
    }
}
