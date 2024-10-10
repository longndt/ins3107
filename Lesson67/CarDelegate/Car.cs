using System;
namespace CarDelegate
{
    public class Car
    {
        public delegate void CarEngineHandler(string messageForCaller);
        // Now a public member!
        public CarEngineHandler listOfHandlers;

        public void Accelerate(int delta)
        {
            if (listOfHandlers != null)
            {
                listOfHandlers("Sorry, this car is dead...");
            }
        }
    }
}
