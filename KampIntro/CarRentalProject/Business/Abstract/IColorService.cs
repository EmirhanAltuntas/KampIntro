using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetColorDetails();
        List<Color> GetColorsByName(string name);
        string Update(Color color);
        string Delete(Color color);
        string Add(Color color);
    }
}
