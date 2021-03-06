﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId+" "+car.Description );
            }
            Console.WriteLine("--------");
            foreach (var car in carManager.GetAllById(1))
            {
                Console.WriteLine(car.CarId+" "+car.Description);
            }
        }
    }
}
