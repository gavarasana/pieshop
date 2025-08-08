namespace Ravi.PieShop.Components.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>
        {
            typeof(widgets.InboxWidget),
            typeof(widgets.EmployeeCountWidget)
           
        };
    }
}
