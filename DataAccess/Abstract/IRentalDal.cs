using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             join u in context.Users
                             on cu.UserId equals u.UserId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId

                             select new RentalDetailDto
                             {
                                 RentalId = r.RentId,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice
                                 
                             };
                return result.ToList();
            }



        }
    }
}
