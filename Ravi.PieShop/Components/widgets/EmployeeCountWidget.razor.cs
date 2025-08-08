using Ravi.PieShop.Services;

namespace Ravi.PieShop.Components.widgets
{
    public partial class EmployeeCountWidget
    {
        public int EmployeeCount { get; set; } = 0;
        protected override void OnInitialized()
        {
            // Simulate fetching employee count from a service or database
            EmployeeCount =  MockDataService.Employees?.Count ?? 0; // Use the Employees property from MockDataService
        }
    }
}
