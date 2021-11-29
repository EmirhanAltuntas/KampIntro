using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<CarDetailDto> GetBrandDetails();
        List<Brand> GetBrandsByName(string name);
        string Update(Brand brand);
        string Delete(Brand brand);
        string Add(Brand brand);
    }
}
