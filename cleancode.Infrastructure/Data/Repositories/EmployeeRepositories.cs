using cleancode.Application.Repositories;
using cleancode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cleancode.Infrastructure.Data.Repositories
{
    internal class EmployeeRepositories : BaseRepositories<Employee>, IEmployeeRepositories
    {
        public EmployeeRepositories(AppDbContext context) : base(context)
        {
        }
    }
}
