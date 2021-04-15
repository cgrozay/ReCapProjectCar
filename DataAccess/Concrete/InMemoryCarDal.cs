using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=87500,Description="2.El 1 yıl garantili ürün"},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=2016,DailyPrice=87500,Description="2.El 1 yıl garantili ürün"},
                new Car{CarId=3,BrandId=1,ColorId=2,ModelYear=2014,DailyPrice=87500,Description="2.El 1 yıl garantili ürün"},
                new Car{CarId=4,BrandId=2,ColorId=2,ModelYear=2018,DailyPrice=87500,Description="2.El 1 yıl garantili ürün"},
                new Car{CarId=5,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=87500,Description="Sıfır 2 yıl garantili ürün"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);   
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(p => p.CarId==car.CarId).ToList();
            
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carTorUpdete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carTorUpdete.BrandId = car.BrandId;
            carTorUpdete.ColorId = car.ColorId;
            carTorUpdete.DailyPrice = car.DailyPrice;
            carTorUpdete.Description = car.Description;
            _cars.Add(carTorUpdete);
        }
    }
}
