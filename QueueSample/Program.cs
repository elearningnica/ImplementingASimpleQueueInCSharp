using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> carsMaintenance = new Queue<string>();

            //adding values to the queue
            carsMaintenance.Enqueue("Nissan");
            carsMaintenance.Enqueue("Toyota");
            carsMaintenance.Enqueue("Chevrolet");
            carsMaintenance.Enqueue("Suzuki");
            carsMaintenance.Enqueue("Hyundai");

            int carsInQueue = carsMaintenance.Count;

            for(int i=0; i<carsInQueue; i++)
            { 
                Console.WriteLine("Number of cars in queue: {0}", carsMaintenance.Count);
                Console.WriteLine("Car on maintenance: {0}", carsMaintenance.Peek());
                carsMaintenance.Dequeue(); //removing a value from the queue
                Console.ReadLine();
            }

        }
    }
}
