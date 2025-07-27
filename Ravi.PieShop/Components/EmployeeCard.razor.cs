using Microsoft.AspNetCore.Components;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
    }
}
