using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : IEntityRepositoryBase<Customer, Northwind2Context>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {

            using (Northwind2Context context = new Northwind2Context())
            {

                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 ComponyName = c.CompanyName
                             };

                //var lst= result.ToList();

                return result.ToList();
            }
        }
    }
}
