using Microsoft.AspNetCore.Components;
using Ravi.PieShop.Contracts.Services;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components.Pages
{
    public partial class EmployeeDetail
    {
        private const string PageTitle = "Employee Detail";

        [Inject]
        public IEmployeeService EmployeeService { get; set; } = default!;

        [Parameter]
        public int EmployeeId { get; set; }

        private Employee? _employee = default!;
        private IEnumerable<TimeRegistration>? _timeRegistrations;

        protected async override Task OnInitializedAsync()
        {
            
            _employee = await EmployeeService.GetEmployeeByIdAsync(EmployeeId);
            if (_employee == null)
            {
                throw new InvalidOperationException($"Employee with ID {EmployeeId} not found.");
            }

            //_timeRegistrations = await EmployeeService.GetTimeRegistrationsForEmployeeAsync(EmployeeId);
        }

        private void ChangeHolidayState()
        {
            _employee.IsOnHoliday = !_employee.IsOnHoliday;
        }
    }
}
