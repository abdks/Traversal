using DatatAccessLayer.Abstract;
using DatatAccessLayer.Concrete;
using DatatAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatAccessLayer.EntityFreamework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using(var c = new Context()) 
            {
            return c.Comments.Include(x=>x.Destination).ToList();
            }
        }
    }
}
