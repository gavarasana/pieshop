using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee?> GetEmployeeByIdAsync(int employeeId);
     
    }
}
