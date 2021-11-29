using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public string Add(Color color)
        {
            _colorDal.Add(color);
            return "Added Color";
        }

        public string Delete(Color color)
        {
            _colorDal.Delete(color);
            return "Deleted Color";
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetColorsByName(string name)
        {
            return _colorDal.GetAll(c => c.ColorName == name);
        }

        public List<Color> GetColorDetails()
        {
            throw new NotImplementedException();
        }

        public string Update(Color color)
        {
            _colorDal.Update(color);
            return "Updated Color";
        }
    }
}
