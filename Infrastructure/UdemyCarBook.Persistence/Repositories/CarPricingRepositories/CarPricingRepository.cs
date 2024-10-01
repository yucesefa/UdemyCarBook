using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.AppliCation.Interfaces.CarPricingInterfaces;
using UdemyCarBook.AppliCation.ViewModels;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).Where(z => z.PricingId == 3).ToList();
            return values;
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {
            throw new NotImplementedException();
        }

        public List<CarPricingViewModel> GetCarPricingWithTimePeriod1()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "select * from (select (Brands.Name+ ' ' +Model) as Model,PricingId,Amount,CoverImageUrl from CarPricings inner join Cars on Cars.CarId=CarPricings.CarId inner join Brands on Brands.BrandId=Cars.BrandId)\r\nas SourceTable Pivot(Sum(Amount) For PricingId in ([2],[3],[4])) as PivotTable;\r\n";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel viewModel = new CarPricingViewModel()
                        {
                            Model = reader["Model"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Amounts = new List<decimal>
                            {
                                Convert.ToDecimal(reader["2"]),
                                Convert.ToDecimal(reader["3"]),
                                Convert.ToDecimal(reader["4"])
                            }

                          
                        };
                        values.Add(viewModel);
                    }
                }
                _context.Database.CloseConnection();
                return values;
            }
        }
    }
}
//List<CarPricing> values = new List<CarPricing>();
//using (var command = _context.Database.GetDbConnection().CreateCommand())
//{
//    command.CommandText = "select * from (select (Brands.Name+ ' ' +Model) as Model,PricingId,Amount from CarPricings inner join Cars on Cars.CarId=CarPricings.CarId inner join Brands on Brands.BrandId=Cars.BrandId)\r\nas SourceTable Pivot(Sum(Amount) For PricingId in ([2],[3],[4])) as PivotTable;\r\n";
//    command.CommandType=System.Data.CommandType.Text;
//    _context.Database.OpenConnection();
//    using (var reader = command.ExecuteReader())
//    {
//        while (reader.Read())
//        {
//            CarPricing carPricing = new CarPricing();
//            Enumerable.Range(1, 3).ToList().ForEach(x =>
//            {
//                if (DBNull.Value.Equals(reader[x]))
//                {
//                    carPricing.
//                }
//                else
//                {

//                }
//            });
//            values.Add(carPricing);
//        }
//    }
//    _context.Database.CloseConnection();
//}
//var values = from x in _context.CarPricings
//             group x by x.PricingId into g
//             select new
//             {
//                 CarId = g.Key,
//                 DailyPrice = g.Where(y => y.CarPricingId == 2).Sum(z => z.Amount),
//                 WeeklyPrice = g.Where(y => y.CarPricingId == 3).Sum(z => z.Amount),
//                 MonthlyPrice = g.Where(y => y.CarPricingId == 4).Sum(z => z.Amount)
//             };
//return values.ToList();