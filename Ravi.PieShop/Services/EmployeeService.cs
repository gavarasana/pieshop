using Ravi.PieShop.Contracts.Repositories;
using Ravi.PieShop.Contracts.Services;
using Ravi.PieShop.Repositories;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ITimeRegistrationRepository _timeRegistrationRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, ITimeRegistrationRepository timeRegistrationRepository)
        {
            _employeeRepository = employeeRepository;
            _timeRegistrationRepository = timeRegistrationRepository;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int employeeId)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(employeeId);
        }

        public Task<List<TimeRegistration>> GetTimeRegistrationsForEmployeeAsync(int employeeId)
        {
            return _timeRegistrationRepository.GetTimeRegistrationsForEmployeeAsync(employeeId);
        }

        public Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployeeAsync(int employeeId, int pageSize, int startIndex)
        {
            return _timeRegistrationRepository.GetPagedTimeRegistrationsForEmployeeAsync(employeeId, pageSize, startIndex);
        }

        public async Task<int> GetTotalTimeRegistrationsCountForEmployeeAsync(int employeeId)
        {
            return await _timeRegistrationRepository.GetTotalTimeRegistrationsCountForEmployeeAsync(employeeId);
        }
    }
}

