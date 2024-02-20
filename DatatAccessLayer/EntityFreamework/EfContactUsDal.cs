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
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactByFalse()
        {
            using(var context = new Context())
            {
                var values = context.contactUses.Where(x=>x.MessageStatus==false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListContactByTrue()
        {
            using (var context = new Context())
            {
                var values = context.contactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
