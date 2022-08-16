using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Carmanager : ICarService
    {
        ICarDal _CarDal;
        

        public Carmanager(ICarDal carDal)
        {
            _CarDal = carDal;
        }
         
              
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>> (_CarDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>> (_CarDal.GetAll(C => C.BrandId==id), Messages.CarsListedByBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorName(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c=>c.ColorId==id), Messages.CarsListedByColorName);

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_CarDal.GetCarDetails(), Messages.CarsDetails);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
           
            ValidationTool.Validate(new CarValidator(), car);

            _CarDal.Add(car);
            //return new Result(true,"Ekleme yapıldı")
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _CarDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
             _CarDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
