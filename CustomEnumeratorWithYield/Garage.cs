using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CustomEnumeratorWithYield
{
    //garage contains a set of cars
   public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        
        //fill with some car objects upon startup
        public Garage()
        {
            carArray[0] = new Car("Bitto", 80);
            carArray[1] = new Car("Cruz", 40);
            carArray[2] = new Car("Big for nothing", 70);
            carArray[3] = new Car("Pencil Light", 60);

        }

        public IEnumerator GetEnumerator()
        {
            //this will get thrown immediately
            throw new Exception("this will get called");

            return actualImplementation();

            IEnumerator actualImplementation()
            { 
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
            
        }
        public IEnumerable GetTheCars(bool returnedReversed)

        {
            //do some error checking here
            return actualImplementation();

            IEnumerable actualImplementation()
            {
                //return the items in reversed
                if (returnedReversed)
                {
                    for(int i=carArray.Length; i != 0; i--)
                    {
                        yield return (carArray[i - 1]);
                    }
                }
                else
                {
                    //rturned the car as arranged in the  array
                    foreach(Car c in carArray)
                    {
                       yield return c;
                    }
                }
            }

        }

        
    }
}
