using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Interfaces.CarFeatureInterfaces
{
	public interface ICarFeatureRepository
	{
		List<CarFeature> GetCarFeaturesByCarID(int carID);
		void ChangeCarFeatureAvailableToFalse(int id);
		void ChangeCarFeatureAvailableToTrue(int id);
		void CreateCarFeatureByCar(CarFeature carFeature);
	}
}
