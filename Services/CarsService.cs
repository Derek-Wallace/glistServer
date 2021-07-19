using System;
using System.Collections.Generic;
using glistServer.Data;
using glistServer.Models;

namespace glistServer.Services
{
  public class CarsService
  {
    private readonly CarsRepository _carsRepo;

    public CarsService(CarsRepository carsRepo)
    {
      _carsRepo = carsRepo;
    }
    public List<Car> GetAll()
    {
      return _carsRepo.GetAll();
    }
    public Car CreateCar(Car carData)
    {
      return _carsRepo.Create(carData);
    }
  }
}
