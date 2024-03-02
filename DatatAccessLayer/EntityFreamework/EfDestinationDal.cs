using DatatAccessLayer.Abstract;
using DatatAccessLayer.Concrete;
using DatatAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatAccessLayer.EntityFreamework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public List<Destination> GetLast4Destinations()
        {
            using (var Context = new Context())
            {
                var values = Context.Destinations.Take(4).OrderByDescending(x=>x.DestinationID).ToList();
                return values;
            }
        }
    }
}
