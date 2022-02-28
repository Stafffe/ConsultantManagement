using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CM.Services.AssignmentApi.Models
{
    public class AssignmentType
    {
        public Guid Id { get; set; }
        public int Percentage { get; set; }

        [Required]
        public IEnumerable<Assignment_Type> Assignment_Type { get; set; }
    }
}
