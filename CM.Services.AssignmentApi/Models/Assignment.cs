using System.ComponentModel.DataAnnotations;

namespace CM.Services.AssignmentApi.Models
{
    public class Assignment
    {
        [Key]
        public Guid AssignmentId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }


        [Required]
        public IEnumerable<Specification> Specifications { get; set; }

        [Required]
        public IEnumerable<Assignment_Category> Assignment_Category { get; set; }
        [Required]
        public IEnumerable<Assignment_Length> Assignment_Length { get; set; }
        [Required]
        public IEnumerable<Assignment_Type> Assignment_Type { get; set; }
    }
}
