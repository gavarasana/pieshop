using Microsoft.AspNetCore.Components;

namespace Ravi.PieShop.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
