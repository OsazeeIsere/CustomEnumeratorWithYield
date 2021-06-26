using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with yield keyword");
            Garage carLot = new Garage();
            //get items using the GetEnumerator
            foreach(Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrSpeed);
                Console.WriteLine();
                            
            }
            // get items in reverse using named iterator
            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrSpeed);

            }
            Console.ReadLine();

        }
        
    }
}
