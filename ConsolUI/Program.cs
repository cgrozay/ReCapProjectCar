using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId+" "+car.CarId+" "+car.Description);


            }

            Console.WriteLine("Hello World!");
        }
    }
}
