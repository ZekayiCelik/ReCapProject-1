using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IEntityRepositoryBase<Car, Northwind2Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {


           

            using (Northwind2Context context = new Northwind2Context())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new CarDetailDto
                             {
                                 CarName=car.CarName ,                        
                                ColorName=color.ColorName,
                                DailiyPrice=car.DailyPrice,
                                BrandName= brand.BrandName,
                                Description=car.Description,
                                ModelYear=car.ModelYear,
                                
                                
                             };

               return result.ToList();
            }

    

    }
    }
}
