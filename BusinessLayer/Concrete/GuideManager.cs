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
           return _guideDal.GetByID(id);
        }

        public void TAdd(Guide t)
        {
           _guideDal.Insert(t); 
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public void TUpdate(Guide t)
        {
           _guideDal.Update(t);
        }
    }
}
