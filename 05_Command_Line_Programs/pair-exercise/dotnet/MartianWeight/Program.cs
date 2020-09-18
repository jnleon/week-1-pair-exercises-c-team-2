using System;

namespace MartianWeight
{
    /*
    In case you've ever pondered how much you weight on Mars, here's the calculation:
    Wm = We* 0.378
    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

    Write a command line program which accepts a series of Earth weights from the user  
    and displays each Earth weight as itself, and its Martian equivalent.


    C:\Users> MartianWeight  
    Enter a series of Earth weights (space-separated): 98 235 185

    98 lbs.on Earth, is 37 lbs.on Mars.
    235 lbs.on Earth, is 88 lbs.on Mars.
    185 lbs.on Earth, is 69 lbs.on Mars. 
    */
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter series of Earth Weights : ");
            string We = Console.ReadLine();


            string[] str_We = We.Split(" ");

                for (int i = 0; i < str_We.Length; i++) 
            {
                decimal stringWe = decimal.Parse(str_We[i]);

                decimal Wm = stringWe * (decimal)0.378;

                Console.WriteLine("{0} lbs. on Earth, is {1} lbs. on Mars." , stringWe, Wm);
            }

        }
    }
}
