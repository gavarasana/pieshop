using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ravi.PieShop.Shared.Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; }

        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(10)]
        public string? Zip { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }

        public int? CountryId { get; set; }

        public Country? Country { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        public bool Smoker { get; set; } = false;

        public MaritalStatus? MaritalStatus { get; set; }

        public Gender? Gender { get; set; }

        public bool IsOnHoliday { get; set; } = false;

        [MaxLength(250)]
        public string Comment { get; set; } = string.Empty;

        public DateTime? JoinedDate { get; set; }

        public DateTime? ExitDate { get; set; }

        public int? JobCategoryId { get; set; }

        public JobCategory? JobCategory { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }


        [NotMapped]
        public byte[]? ImageContent { get; set; }

        [MaxLength(250)]
        public string? ImageName { get; set; }
    }
}
