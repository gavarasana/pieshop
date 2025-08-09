using Microsoft.EntityFrameworkCore;
using Ravi.PieShop.Contracts.Repositories;
using Ravi.PieShop.Data;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Repositories
{
    public class TimeRegistrationRepository : ITimeRegistrationRepository
    {
        private readonly AppDbContext _context;
        public TimeRegistrationRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<TimeRegistration>> GetTimeRegistrationsForEmployeeAsync(int employeeId)
        {
            return await _context.TimeRegistrations
                .Where(tr => tr.EmployeeId == employeeId)
                .ToListAsync();
        }
    }
}
