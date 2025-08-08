using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Ravi.PieShop.Contracts.Repositories;
using Ravi.PieShop.Data;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Repositories
{

    public class EmployeeRepository :  IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext() ?? throw new InvalidOperationException("Failed to create DbContext.");
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public Task<Employee?> GetEmployeeByIdAsync(int employeeId)
        {
            if (employeeId <= 0)
            {
                throw new ArgumentException("Employee ID must be greater than zero.", nameof(employeeId));
            }
            return _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }
    }

    //public class EmployeeRepository(IDbContextFactory<AppDbContext> appDbContextFactory) : RepositoryBase<AppDbContext>(appDbContextFactory), IEmployeeRepository
    //{
    //    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    //    {
    //        return await _context.Employees.ToListAsync();
    //    }

    //    public Task<Employee?> GetEmployeeByIdAsync(int employeeId)
    //    {
    //        if (employeeId <= 0)
    //        {
    //            throw new ArgumentException("Employee ID must be greater than zero.", nameof(employeeId));
    //        }
    //        return _context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
    //    }
    //}
}