﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.InMemory.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
