using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatatAccessLayer.Abstract
{
	public interface IGenericDal<T>
	{
		void Insert (T t);
		void Delete (T t);
		void Update (T t);
		List<T> GetAll ();
		T GetByID (int id);
		List<T> GetAllByFilter (Expression<Func<T,bool>>filter);
	}
}
