using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using glistServer.Models;

namespace glistServer.Data
{
  public class CarsRepository
  {
    private readonly IDbConnection _db;

    public CarsRepository(IDbConnection db)
    {
      _db = db;
    }
    public List<Car> GetAll()
    {
      var sql = "SELECT * FROM cars";
      return _db.Query<Car>(sql).ToList();
    }
    public Car Create(Car carData)
    {
      var sql = @"
      INSERT INTO cars(name, yr)
      VALUES(@Name, @yr);
      SELECT LAST_INSERT_ID();
      ";

      int id = _db.ExecuteScalar<int>(sql, carData);
      carData.Id = id;
      return carData;
    }
  }
}