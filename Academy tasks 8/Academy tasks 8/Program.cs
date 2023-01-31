using System;

namespace Academy_tasks_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            //student1.FullName = "Nigar Mahmudova";
            //student1.Age = 22;

            //Console.WriteLine(student1.Age);


            Vehicle vehicle1 = new Vehicle();
            vehicle1.Drive(10);
            vehicle1.Drive(15);
            vehicle1.Drive(20);
            vehicle1.Drive(10);

            Car car1 = new Car(50);
            car1.FuelCapacity = 80;
            car1.FuelFor1Km = 0.5;

            car1.AddFuel(10);
            car1.AddFuel(15);
            car1.AddFuel(19);

            car1.FuelCapacity = 60;

            car1.Drive(3);
            car1.Drive(7);
            car1.Drive(20);
            car1.Drive(100);

            Console.WriteLine("Capacity..." + car1.FuelCapacity);
            Console.WriteLine("Current..." + car1.CurrentFuel);
            Console.WriteLine("Mileage..." + car1.Mileage);
        }
    }
}
