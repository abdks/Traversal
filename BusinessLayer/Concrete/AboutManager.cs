﻿using BusinessLayer.Abstract;
using DatatAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
           _aboutDal = aboutDal;
        }
        public List<About> GetAll()
		{
			return _aboutDal.GetAll();
		}

		public About GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(About t)
		{
			_aboutDal.Insert(t);
		}

		public void TDelete(About t)
		{
			_aboutDal.Delete(t);
		}

		public void TUpdate(About t)
		{
			_aboutDal.Update(t);
		}
	}
}
