using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Contracts.Repositories
{
    public interface ITimeRegistrationRepository
    {
        Task<IEnumerable<TimeRegistration>> GetTimeRegistrationsForEmployeeAsync(int employeeId);
    }
}
