using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brand;
        public InMemoryBrandDal()
        {
            _brand = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Renault"},
                new Brand{BrandId=2,BrandName="Mercedes-Benz"},
                new Brand{BrandId=3,BrandName="Dacia"},
                new Brand{BrandId=4,BrandName="Fiat"},

            };
        }
        public void Add(Brand brand)
        {
            _brand.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brand.SingleOrDefault(b=>b.BrandId==brand.BrandId);
            _brand.Remove(brandToDelete);
        }

        public List<Brand> GetAllBrands()
        {
            return _brand;
        }

        public List<Brand> GetByBrandId(int BrandId)
        {
            return _brand.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brand.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
