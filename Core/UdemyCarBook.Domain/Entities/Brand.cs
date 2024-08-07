using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }    
        public int Name { get; set; }   
        public List<Car> Cars { get; set; }
    }
}
