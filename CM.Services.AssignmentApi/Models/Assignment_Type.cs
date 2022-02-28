namespace CM.Services.AssignmentApi.Models
{
    public class Assignment_Type
    {
        public int Id { get; set; }

        public Guid AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        public Guid TypeId { get; set; }
        public AssignmentType AssignmentType { get; set; }

    }
}
