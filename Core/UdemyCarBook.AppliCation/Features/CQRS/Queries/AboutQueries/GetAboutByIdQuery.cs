using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.AppliCation.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    {
        public int AboutId { get; set; }

        public GetAboutByIdQuery(int aboutId)
        {
            AboutId = aboutId;
        }
    }
}
