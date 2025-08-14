using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Contracts.Repositories
{
    public interface ITimeRegistrationRepository
    {
        Task<List<TimeRegistration>> GetTimeRegistrationsForEmployeeAsync(int employeeId);

        Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployeeAsync(int employeeId, int pageSize, int startIndex);

        Task<int> GetTotalTimeRegistrationsCountForEmployeeAsync(int employeeId);
    }
}
