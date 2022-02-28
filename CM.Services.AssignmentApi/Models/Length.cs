using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CM.Services.AssignmentApi.Models
{
    public class Length
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int Month { get; set; }
        [Required]
        public IEnumerable<Assignment_Length> Assignment_Length { get; set; }
    }
}
