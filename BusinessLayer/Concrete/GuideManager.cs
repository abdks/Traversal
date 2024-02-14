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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public List<Guide> GetAll()
        {
           return _guideDal.GetAll();
        }

        public Guide GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
