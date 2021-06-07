using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    // Inheritance is a relation ship
    class Vehicle{
        // member variable
        public int vehicleId = 1;
        public string brand = "Ford";
        // member methods
        public void maxSpeed(){
            Console.WriteLine("Max speed is 200kmph");
    }}
    class Car : Vehicle{
        public string model = "mustang";
    }
    class Truck : Vehicle{
        public string model = "xyz";
    }
    class InheritanceEx{
         void Main(){
            // creating child object will give access to all the memebre from child and parent
            Car c = new Car();
            Console.WriteLine(c.brand, c.model);
            // creating parent class object will not give access to child class members.
            Vehicle v = new Vehicle();
            Console.WriteLine(v.brand);
            // parent class variable can hold child class objects but can accessbile only parent members.
            Vehicle v1 = new Car();
            Vehicle v2 = new Truck();
            Console.WriteLine(v1.vehicleId.ToString(), v2.vehicleId);
            // child variable cannot hold a parent object.
            // Car c1 = new Vehicle();
        }

    }
}
