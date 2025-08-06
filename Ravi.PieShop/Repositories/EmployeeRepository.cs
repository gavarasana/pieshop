using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Ravi.PieShop.Contracts.Repositories;
using Ravi.PieShop.Data;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Repositories
{
    public class EmployeeRepository(IDbContextFactory<AppDbContext> appDbContextFactory) : RepositoryBase<AppDbContext>(appDbContextFactory), IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public Task<Employee?> GetEmployeeByIdAsync(int employeeId)
        {
            if (employeeId <= 0)
            {
                throw new ArgumentException("Employee ID must be greater than zero.", nameof(employeeId));
            }
            return _context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }
    }
}