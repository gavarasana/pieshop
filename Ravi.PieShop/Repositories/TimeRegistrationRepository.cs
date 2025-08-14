using Microsoft.EntityFrameworkCore;
using Ravi.PieShop.Contracts.Repositories;
using Ravi.PieShop.Data;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Repositories
{
    public class TimeRegistrationRepository : ITimeRegistrationRepository
    {
        private readonly AppDbContext _appDbContext;
        public TimeRegistrationRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext() ?? throw new InvalidOperationException("Failed to create DbContext.");
        }

        public async Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployeeAsync(int employeeId, int pageSize, int startIndex)
        {
            return await _appDbContext.TimeRegistrations
                .Where(tr => tr.EmployeeId == employeeId)
                .OrderBy(tr => tr.StartTime) // Ensure consistent ordering
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<List<TimeRegistration>> GetTimeRegistrationsForEmployeeAsync(int employeeId)
        {
            return await _appDbContext.TimeRegistrations
                .Where(tr => tr.EmployeeId == employeeId)
                .ToListAsync();
        }

        public async Task<int> GetTotalTimeRegistrationsCountForEmployeeAsync(int employeeId)
        {
           return await _appDbContext.TimeRegistrations
                .CountAsync(tr => tr.EmployeeId == employeeId);
        }
    }
}
