using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        public static void Main(string[] args)
        {

            Prime_numbers(new int[] { 1,214,215});
            //Count_Non_Repetitive_Characters("geeksforgeeks");
            //Count_Repetitive_Characters("geeksforgeeks");
            //Sum_even_numbers_in_Fabonacci(400);
            //int[] input = new int[] { 20, 30, 25, 59, 60, 32 };
            // Large_small_number_in_Array(input);
           // Missing_number_in_array(new int[] { 1, 2, 3, 5, 6 }, 6);
            binary_search();
        }
        public static HashSet<object> set = new HashSet<object>();
        public static int max_count = 256;
        public static  List<object> output = new List<object>();
     

        static bool[] repated = new bool[max_count];

        public static void Count_Non_Repetitive_Characters(string input)
        {


            for (int i = 0; i < 10; i++)
            {
                char[] x = input.ToCharArray();

                     

                if (!repated[x[i]])
                {
                    if (!output.Contains(x[i]))
                    {
                        output.Add(x[i]);
                        Console.WriteLine($"adding {x[i]} to list");
                    }
                    else
                    {
                        output.Remove(x[i]);
                        repated[x[i]] = true;
                        Console.WriteLine($"removed repated item {x[i]}");
                    }


                }



            }
            Console.WriteLine(output.Count);
            Console.Read();
        }

        public static void Count_Repetitive_Characters(string input)
        {
            int count = 0;
            char[] y = input.ToCharArray();

            foreach( var v in y )
            {
                if (output.Contains(v))
                    count++;
                else
                {
                    output.Add(v);
                }
            }
            object[] final = output.ToArray();
            foreach( var v in final)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine(final.Length);

            

           // Console.WriteLine(count);
            Console.Read();
              

        }
     public static void Sum_even_numbers_in_Fabonacci( int limit)
        {
            int a = 0; int b = 1; int c = 0; int EvenSum = 0;
            List<int> count = new List<int>();
            for( int i = 0; i < limit; i++)
            {
                c = a + b;
                //Console.WriteLine("Fabonacci starting"+"\n"+c);

                if (c % 2 == 0)
                {
                    count.Add(c);
                    if (count.Count == 10)
                        break;

                }
                a = b;
                b = c;
                
            }
            foreach( var v in count)
                Console.WriteLine(v);

            Console.WriteLine("test"+count[5]);
            //Console.WriteLine($"sum of even number in fabonacci series is {EvenSum}");
            Console.Read();
        }   
        
        public static void Large_small_number_in_Array(int[] input)
        {
            int large = input[0], small = input[0];

            for ( int i=1; i<input.Length;i++)
            {

                output.Add(input[i]);

                //if (input[i] > large)
                //{
                //    large = input[i];
                //    output.Add(large);
                //}
               // if (input[i] < small)
                    //small = input[i];
            }

            output.Sort();// we will use sort function of list class.
            output.Reverse();
            for( int j=0; j<=2;j++)
            {
                Console.Write( $"{output[j]},");
            }
           // Console.WriteLine($"largest number {large} and smallest number {small}");
            Console.Read();
            
        }
        public static void Missing_number_in_array(int[] input, int n)// array = 51,52,53,54,55,57 - one missing number 
        {
            int Sum_actual_array = 0;
            int Sum_expected_array = 0;

            for(int i=0;i<input.Length; i++)
            {
                Sum_actual_array += input[i];
            }

            Sum_expected_array= n*(n+1)/2;
            int missing_array = Sum_expected_array - Sum_actual_array;
            Console.WriteLine($"missing array is {missing_array}");
            Console.Read();

                }


        public static void binary_search () // binary search works on sorted array only , we need to find index of any number in soreted array
        {  
            
            //Array.Sort(input);
            //int key=0 ;
            //int min = 0;
            //int max = input.Length - 1;
            //while (min <= max)
            //{
            //    int mid = (max - min) / 2;
            //    if (min > max)
            //        return 0;
            //    if (key == input[mid]) ;
            //    return mid;
            //    if (key < input[mid])
            //         min = mid - 1;
               
            //    if (key > input[mid])
            //        return max = mid + 1;

            //    return 1;
            //}
            //return 1;

              int opt = Array.BinarySearch(new int[] { 56, 67, 87, 90 }, 87);
            Console.WriteLine($"Index of is {opt}");
            Console.Read();

        }

        public static void Prime_numbers(int[] Numbers)
        {   
            for (int i=0; i<Numbers.Length;i++)
            {
                for (int j = 2; j < Numbers[i]/2; j++)
                {
                    if (Numbers[i] % j == 0 && Numbers[i] != j)
                    { 
                        break;
                     }
                    else if(Numbers[i]==2)
                        set.Add(Numbers[i]);
                    else
                        set.Add(Numbers[i]);
                }
                        
            }
  
            
            foreach (var item in set)
            {
                Console.Write($"{item}, ");
            }

            Console.Read();
            

        }
        
        }
      


    }


