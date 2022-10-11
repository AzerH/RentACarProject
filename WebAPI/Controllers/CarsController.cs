using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet ("getall")]
        public IActionResult GetAll()
        {
            //Thread.Sleep(5000);
            var result = _carService.GetAll();
            return Ok(result);

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
            var result = _carService.GetCarById(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);


        }
        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int brandId)
        {
            var result = _carService.GetByBrandId(brandId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result.Message);


        }
        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int colorId)
        {
            var result = _carService.GetByBrandId(colorId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result.Message);


        }

    }
}
