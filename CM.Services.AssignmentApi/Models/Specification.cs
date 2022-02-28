using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CM.Services.AssignmentApi.Models
{
    public class Specification
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public bool Required { get; set; }

        [ForeignKey(nameof(Assignment))]
        public Guid AssignmentId { get; set; }

        public Assignment? Assignment { get; set; }
    }
}
