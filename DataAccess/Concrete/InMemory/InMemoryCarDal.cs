using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear="1990",DailyPrice=1000,Description="Spor Araba"},
                new Car {CarId=2,BrandId=2,ColorId=2,ModelYear="1991",DailyPrice=1100,Description="Klasik Araba"},
                new Car {CarId=2,BrandId=3,ColorId=2,ModelYear="1992",DailyPrice=1200,Description="Yarış Arabası"},
                new Car {CarId=3,BrandId=4,ColorId=3,ModelYear="1993",DailyPrice=1300,Description="Karavan Araba"},
                new Car {CarId=4,BrandId=5,ColorId=4,ModelYear="1994",DailyPrice=1400,Description="Antika Araba"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
