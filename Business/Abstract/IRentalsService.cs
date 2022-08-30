using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalsService 
    {
        IDataResult<List<Rentals>> GetAll();
        IDataResult<Rentals> GetRentalsByid(int id);

        IDataResult<List<Rentals>> GetRentalByCarId(int id);

        IDataResult<List<Rentals>> GetRentalsByCustomerId(int id);

        IResult Add(Rentals rental);
        IResult Delete(Rentals rental);
        IResult Update(Rentals rental);
    }
}
