namespace CM.Services.AssignmentApi.Models
{
    public class Assignment_Category
    {
        public int Id { get; set; }

        public Guid AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
