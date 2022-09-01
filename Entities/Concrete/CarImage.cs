using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public int ImageId { get; set; }
        public int ImageCarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime ImageDate { get; set; }

    }
}
