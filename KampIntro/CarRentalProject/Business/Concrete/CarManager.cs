﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
        public void Add(Car car)
        {
            if (car.Description.Length<=2 && car.DailyPrice<=0)
            {
                Console.WriteLine("Error");
                
            }
            else
            {
                _carDal.Add(car);
            }
        }
        public string Update(Car car)
        {
            _carDal.Update(car);
            return "Updated";

        }
        public string Delete(Car car)
        {
            _carDal.Delete(car);
            return "Deleted";
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetProductDetails();
        }
    }
}