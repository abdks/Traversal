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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contact;

        public ContactUsManager(IContactUsDal contact)
        {
            _contact = contact;
        }

        public List<ContactUs> GetAll()
        {
           return _contact.GetAll();
        }

        public ContactUs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListContactByFalse()
        {
          return _contact.GetListContactByFalse();
        }

        public List<ContactUs> TGetListContactByTrue()
        {
           return _contact.GetListContactByTrue();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
