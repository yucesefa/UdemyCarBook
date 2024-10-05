using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.AppliCation.Interfaces.ReviewInterfaces
{
	public interface IReviewRepository
	{
		public List<Review> GetReviewsByCarId(int carId);
	}
}
