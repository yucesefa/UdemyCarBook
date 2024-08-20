using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.AppliCation.Features.CQRS.Results.CategoryResult
{
    public class GetCategoryByIdQueryResult
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
