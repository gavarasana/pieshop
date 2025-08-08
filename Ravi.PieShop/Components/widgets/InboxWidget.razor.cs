namespace Ravi.PieShop.Components.widgets
{
    public partial class InboxWidget
    {
        public int MessageCount { get; set; } = 0;
        protected override void OnInitialized()
        {
            // Simulate fetching message count from a service or database
            MessageCount = new Random().Next(1, 20); // Random count for demonstration purposes
        }
    }
}
