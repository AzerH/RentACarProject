using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalsService
    {
        IRentalsDal _rentalsDal;
        public RentalManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }
        public IResult Add(Rentals rental)
        {
            _rentalsDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rentals rental)
        {
            _rentalsDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<Rentals>> GetRentalByCarId(int id)
        {
            if (_rentalsDal.Get(r => r.CarId == id) == null)
                return new ErrorDataResult<List<Rentals>>(Messages.RentalNotFound);
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(r => r.CarId == id));
        }

        public IDataResult<List<Rentals>> GetRentalsByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(r => r.CustomerId == id));
        }

        public IDataResult<Rentals> GetRentalsByid(int id)
        {
            return new SuccessDataResult<Rentals>(_rentalsDal.Get(r => r.Id == id), Messages.RentalListed);
        }

        public IResult Update(Rentals rental)
        {
            _rentalsDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
            
        }
    }
}
