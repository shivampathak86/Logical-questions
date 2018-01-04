using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Count_Non_Repetitive_Characters("geeksforgeeks");
        }
        public static int max_count = 256;
        static List<char> output = new List<char>();

        static bool[] repated = new bool[max_count];

        public static void Count_Non_Repetitive_Characters(string input)
        {
          
            
            for (int i=0; i<input.Length;i++)
            {
                char[] x = input.ToCharArray();

                if (!repated[x[i]])
                {
                    if(!output.Contains(x[i]))
                    {
                        output.Add(x[i]);
                    }
                    else
                    {
                        output.Remove(x[i]);
                        repated[x[i]] = true;
                    }


                }

            

            }
            Console.WriteLine(output.Count);
         }



    }
}


     

