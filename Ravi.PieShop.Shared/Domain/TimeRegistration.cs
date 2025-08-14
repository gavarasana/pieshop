using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravi.PieShop.Shared.Domain
{
    public class TimeRegistration
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? TaskDescription { get; set; }
    }
}
