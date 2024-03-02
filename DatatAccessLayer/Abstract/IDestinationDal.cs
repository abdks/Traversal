using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatAccessLayer.Abstract
{
	public interface IDestinationDal:IGenericDal<Destination>
	{
		public List<Destination> GetLast4Destinations();
	}
}
