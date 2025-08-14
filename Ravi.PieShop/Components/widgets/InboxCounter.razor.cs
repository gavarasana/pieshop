using Microsoft.AspNetCore.Components;
using Ravi.PieShop.State;

namespace Ravi.PieShop.Components.widgets
{
    public partial class InboxCounter
    {
        [Inject]
        public SharedState SharedState { get; set; } = default!;
        public int MessageCount { get; set; } = 0;
        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(1, 100); // Simulate message count
            SharedState.MessageCount = MessageCount; // Update shared state
        }       
    }
}
