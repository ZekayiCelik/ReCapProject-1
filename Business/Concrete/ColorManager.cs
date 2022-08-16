using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _ColorDal;

        public ColorManager(IColorDal colorDal)
        {
            _ColorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _ColorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _ColorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
           return new SuccessDataResult<List<Color>>(_ColorDal.GetAll(),Messages.ColorListed);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_ColorDal.Get(c=>c.ColorId==colorId));
          
        }

       

        public IResult Update(Color color)
        {
           _ColorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

       
    }
}
