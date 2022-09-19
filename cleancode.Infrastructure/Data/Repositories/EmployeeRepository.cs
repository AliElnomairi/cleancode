using cleancode.Application.Repositories;
using cleancode.Domain.Entities;


namespace cleancode.Infrastructure.Data.Repositories
{
    internal class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepositories
    {
        public EmployeeRepository(AppDbContext context) : base(context) { }
    }
}
