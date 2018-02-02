using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Turvo
    {


        public static void test()
        {

            int _speedofAlex = Int32.Parse(Console.ReadLine());
            int _speedofBears = Int32.Parse(Console.ReadLine());
            int _speedofCharlie = Int32.Parse(Console.ReadLine());
            int _speedofDouglas = Int32.Parse(Console.ReadLine());

            List<int> SpeedOfAll = new List<int>();

            SpeedOfAll.Add(_speedofAlex);
            SpeedOfAll.Add(_speedofBears);
            SpeedOfAll.Add(_speedofCharlie);
            SpeedOfAll.Add(_speedofDouglas);
            SpeedOfAll.Sort();

            int timetaken = SpeedOfAll[0] * 5 + SpeedOfAll[1] + SpeedOfAll[2] + SpeedOfAll[3];

            Console.WriteLine(timetaken);


            Console.Read();




        }

        public static  void NumberOfIterations()
        {

            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());

            int count = 0;

            while(n > 0)
            { 
    
                count = count + 1;

                n = n - (x - y);

            }
             
            Console.WriteLine(count);
            Console.Read();

        }


    }




}
