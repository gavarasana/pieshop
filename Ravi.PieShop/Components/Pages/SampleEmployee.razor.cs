using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Components.Pages
{
    public partial class SampleEmployee
    {
        public Employee Employee { get; set; }

        protected override void OnInitialized()
        {
            // This method is called when the component is initialized.
            // You can perform any setup or initialization logic here.
            base.OnInitialized();
            Employee = new()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

        }

        private void UpdateName()
        {
                       // This method can be called to update the employee's name.
            // You can add logic here to change the employee's name.
            Employee.FirstName = "Jane";
            Employee.LastName = "Smith";
        }
    }
}
