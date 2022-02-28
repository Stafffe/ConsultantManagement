using System.ComponentModel.DataAnnotations;

namespace CM.Services.AssignmentProcessApi.Models
{
    public class AssignmentProcess
    {
        [Key]
        public Guid AssignmentProcessId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public int Length { get; set; }
        public string Customer { get; set; }
        public string Brocker { get; set; }
        public string Consultant { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
    }
}
