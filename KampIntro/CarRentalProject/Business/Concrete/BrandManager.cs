using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public string Add(Brand brand)
        {
            _brandDal.Add(brand);
            return "Added Brand";
        }

        public string Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return "Deleted Brand";
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<CarDetailDto> GetBrandDetails()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetBrandsByName(string name)
        {
            return _brandDal.GetAll(b => b.BrandName == name);
        }

        public string Update(Brand brand)
        {
            _brandDal.Update(brand);
            return "Updated Brand";
        }
    }
}
