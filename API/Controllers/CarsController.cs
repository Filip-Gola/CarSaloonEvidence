using System.Collections.Generic;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly MockCarRepository _carRepository;
        public CarsController(MockCarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public ActionResult GetCars()
        {
            return Ok(_carRepository.GetCars());
        }

        [HttpGet("{id}")]
        public ActionResult GetCar(int id)
        {
            return Ok(_carRepository.GetCarById(id));
        }

        [HttpGet("search")]
        public ActionResult GetCarsByQuery([FromQuery] QueryParams queryParams)
        {

            List<Car> cars = (List<Car>)_carRepository.GetCarsByQuery(queryParams);

            if (cars.Count > 0)
            {
                return Ok(cars);
            }

            return NoContent();
        }
    }
}