using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 9, ColorId = 4, ModelYear = 2000, DailyPrice = 750, Description = "Lada Vega Station-Wagon 2000 Model Bordo renk" });

            //foreach (var car in carManager.GetAllDetail())
            //{
            //    Console.WriteLine($"Marka: {car.BrandName}, Model: {car.ModelYear}, Renk: {car.ColorName}, Günlük Kiralık Ücreti: {car.DailyPrice} TL, Açıklama: {car.Description}");
            //}


            /*
            // Renk

            List<Color> listColor = new ColorManager(new EfColorDal()).GetAll();
            foreach (var color in listColor)
            {
                Console.WriteLine($"Id: {color.ColorId} Renk: {color.ColorName}");
            }*/


            /*
            // Brand

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            List<Brand> listBrand =brandManager.GetAll();
            //brandManager.Add(new Brand { BrandName = "Tofaş"});
            foreach (var brand in listBrand)
            {
                Console.WriteLine($"Id: {brand.BrandId} Marka: {brand.BrandName}");
            }*/

            //Console.WriteLine(carManager.CarGetById(1002).BrandId);
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.BrandGetById(1).BrandName);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }


        }
    }
}
