using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Color> GetAllColors();
        List<Color> GetByColorId(int ColorId);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
