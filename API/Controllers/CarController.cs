using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly MockCarRepository _carRepository;
        public CarController(MockCarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public ActionResult<ICollection<Car>> GetCars()
        {
            return Ok(_carRepository.GetCars());
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            return  Ok(_carRepository.GetCarById(id));
        }

        [HttpGet("Manufacturer/id/{manufacturerId}")]
        public ActionResult<Car> GetCarsByManufacturerId(int manufacturerId)
        {
            return Ok(_carRepository.GetCarsByManufacturerId(manufacturerId));
        }

        [HttpGet("Manufacturer/id/{manufacturerId}/types{carTypeId}")]
        public ActionResult<Car> GetCarsByManufacturerIdAndCarTypeId(int manufacturerId, int carTypeId)
        {
            return Ok(_carRepository.GetCarsByManufacturerIdAndCarTypeId(manufacturerId, carTypeId));
        }

        [HttpGet("Manufacturer/id/{manufacturerId}/Received{dateReceived}")]
        public ActionResult<Car> GetCarsByManufacturerIdAndDateReceived(int manufacturerId, DateTime dateReceived)
        {
            return Ok(_carRepository.GetCarsByManufacturerIdAndDateReceived(manufacturerId, dateReceived));
        }

        [HttpGet("Manufacturer/id/{manufacturerId}/Released{dateReleased}")]
        public ActionResult<Car> GetCarsByManufacturerIdAndDateReleased(int manufacturerId, DateTime dateReleased)
        {
            return Ok(_carRepository.GetCarsByManufacturerIdAndDateReleased(manufacturerId, dateReleased));
        }

        [HttpGet("Manufacturer/name/{manufacturerName}")]
        public ActionResult<Car> GetCarsByManufacturerName(string manufacturerName)
        {
            return Ok(_carRepository.GetCarsByManufacturerName(manufacturerName));
        } 
    }
}