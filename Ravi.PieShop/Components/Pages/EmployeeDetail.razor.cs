using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
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
        public List<TimeRegistration>? TimeRegistrations = [];
        private int itemHeight = 100;

        protected async override Task OnInitializedAsync()
        {
            
            _employee = await EmployeeService.GetEmployeeByIdAsync(EmployeeId);
            if (_employee == null)
            {
                throw new InvalidOperationException($"Employee with ID {EmployeeId} not found.");
            }

            TimeRegistrations = await EmployeeService.GetTimeRegistrationsForEmployeeAsync(EmployeeId) ?? [];
        }


        private async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrationsAsync(ItemsProviderRequest request)
        {
            var totalCount = await EmployeeService.GetTotalTimeRegistrationsCountForEmployeeAsync(EmployeeId);
            var numberofRegistrationsToLoad = Math.Min(request.Count, (totalCount - request.StartIndex) );
            var registrations = await EmployeeService.GetPagedTimeRegistrationsForEmployeeAsync(EmployeeId,  numberofRegistrationsToLoad, request.StartIndex);
            return new ItemsProviderResult<TimeRegistration>(registrations, totalCount);
        }
        private void ChangeHolidayState()
        {
            _employee.IsOnHoliday = !_employee.IsOnHoliday;
        }
    }
}
