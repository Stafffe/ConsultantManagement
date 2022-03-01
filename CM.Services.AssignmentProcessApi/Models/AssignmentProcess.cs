using System.ComponentModel.DataAnnotations;

namespace CM.Services.AssignmentProcessApi.Models
{
    public class AssignmentProcess
    {
        [Key]
        public Guid AssignmentProcessId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; } = String.Empty;
        public DateTime? StartDate { get; set; }
        public int Length { get; set; }
        public string Customer { get; set; } = String.Empty;
        public string Brocker { get; set; } = String.Empty;
        public string Consultant { get; set; } = String.Empty;
        public string Action { get; set; } = String.Empty;
        public string Status { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
    }
}
