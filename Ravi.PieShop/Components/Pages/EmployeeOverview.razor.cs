using Microsoft.AspNetCore.Components;
using Ravi.PieShop.Contracts.Services;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components.Pages
{
    public partial class EmployeeOverview
    {
        private const string PageTitle = "Employee Overview";

        [Inject]
        public IEmployeeService EmployeeService { get; set; } = default!;

        private IEnumerable<Employee>? _employees = default!;
        private Employee? _selectedEmployee;

        protected async override Task OnInitializedAsync()
        {
            _employees = await EmployeeService.GetAllEmployeesAsync();
        }
        private void ShowEmployeePopup(Employee employee)
        {
            _selectedEmployee = employee;
        }
    }
}