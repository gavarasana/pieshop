using System.ComponentModel.DataAnnotations;

namespace Ravi.PieShop.Shared.Domain
{
    public class Country
    {
        public int CountryId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
