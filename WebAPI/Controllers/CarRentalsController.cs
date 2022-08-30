using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRentalsController : ControllerBase
    {
        ICarService _carService;
        public CarRentalsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet ("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            return Ok(result.Data);

        }


        [HttpPost("Add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            return Ok(result.Message);
        }
        [HttpGet ("getbyid")]
        
        public IActionResult GetById(int id)
        {
            var result = _carService.GetCarByid(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);


        }

    }
}
