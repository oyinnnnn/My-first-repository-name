using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Airconditioner
    {
        static void Main(string[] args)   //method
        {
            Console.WriteLine("Blowing cool air");

            //int calories = Eating("pasta");
            //Console.WriteLine($"We get {calories} from the food");

            Worrying();
            Console.ReadLine();
        }

        //private int vend;  //field

        //public string Condenser { get; set; }  //field

        //public delegate int AddNumbers(int a, int b);  //delegate

        //public Airconditioner(string compressor);  //constructor


        //~Airconditioner()   //destructor

        //{
        //    Console.WriteLine("Clear the water away");
        //}


        //static int Eating(string food)
        //{
        //    if (food == "rice")
        //    {
        //        return 500;
        //    }
        //    else if (food == "fufu")
        //    {
        //        return 300;
        //    }
        //    else
        //    {
        //        return 100;
        //    }

        //    //method
        //}

        //string CommonNames()
        //{
        //    return "Peace";

        static void Worrying()
        {
            //int amountsofar = 1;
            //while (amountsofar < 10000)
            //{
            //    Console.WriteLine($"Advertise for more sales,we are at {amountsofar} naira");
            //    amountsofar = amountsofar * 2;
            //}

            //int total = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    total = total + i;
            //    Console.WriteLine($"Hello I am {total} for now");
            //}

            int[] apcfans = { 23, 17, 21, 31, 27, 18 };
            {
                int total = 0;
                foreach (var youthage in apcfans)

                {
                    total = total + youthage;
                }
                Console.WriteLine($"the sum of apcfans is {total}");
                    int sum = total;

                        Console.ReadLine();
            }

           



        }
    }
}
  


