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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _AppUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _AppUserDal = appUserDal;
        }

        public List<AppUser> GetAll()
        {
         return  _AppUserDal.GetAll();
        }

        public AppUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}
