using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.ViewModels;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingWithCars();
        List<CarPricing> GetCarPricingWithTimePeriod();
        List<CarPricingViewModel> GetCarPricingWithTimePeriod1();
    }
}
