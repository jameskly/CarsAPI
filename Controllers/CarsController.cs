using CarsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarsAPI.Controllers
{
  public class CarsController : ApiController
  {
    List<Car> cars = new List<Car>();

    public CarsController()
    {
      cars.Add(new Car { Id = 1, Make = "Ford", Model = "Focus", Colour = "Navy", Year = 2019 });
      cars.Add(new Car { Id = 2, Make = "Toyota", Model = "Yaris", Colour = "Black", Year = 2018 });
      cars.Add(new Car { Id = 3, Make = "Honda", Model = "Civic", Colour = "Silver", Year = 2017 });
    }

    // GET: api/Cars
    public List<Car> Get()
    {
      return cars; // Use Postman for testing API
    }

    // GET: api/Cars/5
    public Car Get(int id)
    {
      return cars.Where(x => x.Id == id).FirstOrDefault();  // Use Postman for testing API
    }

    // POST: api/Cars
    public void Post(Car val)
    {
      cars.Add(val);

      // Use Postman software to add new JSON object, eg
      /*
        { 
          Id=4,
          Make = "Mazda", 
          Model = "Mazda3", 
          Colour = "Brown", 
          Year = 2016	
        }
      */
    }

    // PUT: api/Cars/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/Cars/5
    public void Delete(int id)
    {
      cars.RemoveAt(id);  // Use Postman for testing API
    }
  }
}
