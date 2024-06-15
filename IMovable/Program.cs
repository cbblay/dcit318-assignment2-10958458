using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovable
{
    //Creating interface IMovable
    internal class Program
    {
        public interface IMovable
        {
            void Move();
        }
        
        //Creating classes Car and Bicycle
        public class Car : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Car is moving.");
            }
        }
        public class Bicycle : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is moving.");
            }
        }
        //Creating instances
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            Bicycle bike = new Bicycle();
            bike.Move();
        }
    }
}
