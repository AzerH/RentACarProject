using Business.Abstract;
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
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal )
        {
            _colorDal = colorDal;

        }

        public IResult Add(Color color)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Color color)
        {
            throw new NotImplementedException();
        }

       

        public IDataResult<List<Color>> GetByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        

        public IResult Update(Color color)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Color>> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Color> IColorService.GetById(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
