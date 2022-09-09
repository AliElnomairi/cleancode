using cleancode.Application.Repositories;
using cleancode.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleancode.Infrastructure.Data.Repositories
{
    internal class ParkingRepositories : BaseRepositories<Parking>, IParkingRepositories
    {
        public ParkingRepositories(AppDbContext context) : base(context)
        {
        }
    }
}
