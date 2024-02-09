using DatatAccessLayer.Abstract;
using DatatAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatAccessLayer.EntityFreamework
{
	public class EFTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
	{

	}
}
