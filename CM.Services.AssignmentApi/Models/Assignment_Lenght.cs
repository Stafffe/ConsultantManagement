namespace CM.Services.AssignmentApi.Models
{
    public class Assignment_Length
    {
        public int Id { get; set; }

        public Guid AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        public Guid LengthId { get; set; }
        public Length Length { get; set; }

    }
}
