using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Contracts.Services
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Retrieves all employees asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, containing a list of employees.</returns>
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        /// <summary>
        /// Retrieves an employee by their ID asynchronously.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation, containing the employee if found, otherwise null.</returns>
        Task<Employee?> GetEmployeeByIdAsync(int employeeId);
    }
}
