using Microsoft.AspNetCore.Components;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components
{
    public partial class EmployeeQuickView
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        private Employee? _employee;

        protected override void OnParametersSet()
        {
            _employee = Employee;
        }

        private void ClosePopup()
        {
            _employee = null;
        }

    }
}
