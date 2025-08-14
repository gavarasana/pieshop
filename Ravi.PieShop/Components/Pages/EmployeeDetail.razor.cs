using Azure.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Ravi.PieShop.Contracts.Services;
using Ravi.PieShop.Migrations;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components.Pages
{
    public partial class EmployeeDetail
    {
        private const string PageTitle = "Employee Detail";

        [Inject]
        public IEmployeeService EmployeeService { get; set; } = default!;

        [Inject]
        public ILogger<EmployeeDetail> Logger { get; set; } = default!;

        [Parameter]
        public int EmployeeId { get; set; }

        private Employee? _employee = default!;
        private List<TimeRegistration>? TimeRegistrations = [];

        private IQueryable<TimeRegistration> _timeRegistrationsQuery = default!;
        private int ItemCount = 0;

        private PaginationState PaginationState =  new() { ItemsPerPage = 50 };

        private int ItemHeight = 100;

        protected async override Task OnInitializedAsync()
        {
            
            _employee = await EmployeeService.GetEmployeeByIdAsync(EmployeeId);
            if (_employee == null)
            {
                throw new InvalidOperationException($"Employee with ID {EmployeeId} not found.");
            }

            //TimeRegistrations = await EmployeeService.GetTimeRegistrationsForEmployeeAsync(EmployeeId) ?? [];

            TimeRegistrations  = await EmployeeService.GetPagedTimeRegistrationsForEmployeeAsync(EmployeeId, 25, 0);
            _timeRegistrationsQuery = (await EmployeeService.GetTimeRegistrationsForEmployeeAsync(EmployeeId)).AsQueryable();
            ItemCount = _timeRegistrationsQuery.Count();

        }


        private async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrationsAsync(ItemsProviderRequest request)
        {
            Logger.LogInformation("Loading time registrations for employee with ID {EmployeeId} starting at index {StartIndex} with count {Count}", EmployeeId, request.StartIndex, request.Count);
            var totalCount = await EmployeeService.GetTotalTimeRegistrationsCountForEmployeeAsync(EmployeeId);
            var numberofRegistrationsToLoad = request.Count; // Math.Min(request.Count, totalCount - (request.StartIndex * request.Count));
            Logger.LogInformation("Loading {NumberofRegistrationsToLoad} time entries", numberofRegistrationsToLoad);
            var registrations = await EmployeeService.GetPagedTimeRegistrationsForEmployeeAsync(EmployeeId,  numberofRegistrationsToLoad, request.StartIndex);
            return new ItemsProviderResult<TimeRegistration>(registrations, totalCount);
        }
        private void ChangeHolidayState()
        {
            _employee.IsOnHoliday = !_employee.IsOnHoliday;
        }
    }
}
