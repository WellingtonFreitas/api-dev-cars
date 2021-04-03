using DevCars.API.Entities;
using DevCars.API.InputModels;
using DevCars.API.Persistence;
using DevCars.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Controllers
{
    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        private readonly DevCarsDbContext _dbContext;
        public CarsController(DevCarsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET api/cars
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var cars = _dbContext.Cars;
                var carsViewModel = cars.Where(c => c.Status == CarsStatusEnum.Available).Select(c => new CarItemViewModel(c.Id, c.Brand, c.Model, c.Price)).ToList();
                return Ok(carsViewModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        // GET api/cars/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var car = _dbContext.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null)
                {
                    return NotFound();
                }

                var carDetailsViewModel = new CarDetailsViewModel(
                        car.Id, 
                        car.Brand, 
                        car.Model, 
                        car.VinCode, 
                        car.Year, 
                        car.Price, 
                        car.Color, 
                        car.ProductonDate
                    );
                return Ok(carDetailsViewModel);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
        }

        // POST api/cars
        [HttpPost]
        public IActionResult Post([FromBody] AddCarInputModel model)
        {
            try
            {
                var car = new Car(model.VinCode, model.Brand, model.Model, model.Year, model.Price, model.Color, model.ProductionDate);
                _dbContext.Cars.Add(car);
                _dbContext.SaveChanges();

                return CreatedAtAction(
                        nameof(GetById),
                        new { id = car.Id },
                        model
                    );
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
        }

        // PUT api/cars/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateCarInputModel model)
        {
            try
            {
                var car = _dbContext.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null)
                {
                    return NotFound();
                }

                car.Update(model.Color, model.Price);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex )
            {

                return StatusCode(500);
            }
        }

        //DELETE api/cars/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var car = _dbContext.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null)
                {
                    return NotFound();
                }

                car.SetAsSuspended();
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
        }
    }
}
