using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using React.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ReactJSDemoContext _reactJSDemoContext;

        public CarsController(ReactJSDemoContext reactJSDemoContext)
        {
            _reactJSDemoContext = reactJSDemoContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var cars = await _reactJSDemoContext.Car.ToListAsync();
                return Ok(cars);
            }

            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var car = await _reactJSDemoContext.Car.Where(x => x.Id == id).FirstOrDefaultAsync();
                return Ok(car);
            }

            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public async Task<IActionResult> Put(Car car)
        {
            try
            {
                var result = _reactJSDemoContext.Car.Update(car);
                await _reactJSDemoContext.SaveChangesAsync();
                return Ok(car);
            }

            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post(Car car)
        {
            try
            {
                _reactJSDemoContext.Car.Add(car);
                await _reactJSDemoContext.SaveChangesAsync();

                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _reactJSDemoContext.Car.Where(x => x.Id == id).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }

            _reactJSDemoContext.Car.Remove(result);
            await _reactJSDemoContext.SaveChangesAsync();

            return Ok();

        }
    }
}
