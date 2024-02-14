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
    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public List<Comment> GetAll()
        {
           return _CommentDal.GetAll();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
           _CommentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
        public List<Comment> TGetDestinationByID (int id)
        {
            return _CommentDal.GetAllByFilter(x=>x.DestinationID == id);
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _CommentDal.GetListCommentWithDestination();
        }
    }
}
