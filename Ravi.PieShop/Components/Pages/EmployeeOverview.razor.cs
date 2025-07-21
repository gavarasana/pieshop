using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components.Pages
{
    public partial class EmployeeOverview
    {
        private List<Employee>? _employees = default!;
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000); // Simulate a delay for data loading
            _employees = Services.MockDataService.Employees;
        }
    }
}