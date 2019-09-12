using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsAPI.Models
{
  public class Car
  {
    public int Id { get; set; } = 0;
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public string Colour { get; set; } = "";
    public int Year { get; set; } = 0;
  }
}