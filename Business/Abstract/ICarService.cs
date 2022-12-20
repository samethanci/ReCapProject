using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car CarGetById(int carId);
        void Add(Car car);
        void Delete(Car car);  
        void Update(Car car);
        List<CarDetailDto> GetAllDetail();
    }
}
