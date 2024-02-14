using BusinessLayer.Abstract;
using DatatAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _DestinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _DestinationDal = destinationDal;
        }

        public List<Destination> GetAll()
        {
          return _DestinationDal.GetAll();
        }

        public Destination GetById(int id)
        {
                return _DestinationDal.GetByID(id);

        }

        public void TAdd(Destination t)
        {
            _DestinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _DestinationDal.Delete(t);
        }

        public void TUpdate(Destination t)
        {
            _DestinationDal.Update(t);
           
        }
    }
}
