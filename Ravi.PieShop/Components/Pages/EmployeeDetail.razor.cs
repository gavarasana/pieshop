using Microsoft.AspNetCore.Components;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }
        private Employee? _employee = default!;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000); // Simulate a delay for data loading
            _employee = Services.MockDataService.Employees?.FirstOrDefault(e => e.EmployeeId == EmployeeId);
            if (_employee == null)
            {
                //throw new InvalidOperationException($"Employee with ID {EmployeeId} not found.");
                _employee = Services.MockDataService.UnknownEmployee;
            }

        }

        private void ChangeHolidayState()
        {
            _employee.IsOnHoliday = !_employee.IsOnHoliday;
        }
    }
}
