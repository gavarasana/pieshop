using System.ComponentModel.DataAnnotations;

namespace Ravi.PieShop.Shared.Domain
{
    public class JobCategory
    {
        public int JobCategoryId { get; set; }

        [MaxLength(100)]
        public string JobCategoryName { get; set; } = string.Empty;
    }
}
