using CM.Services.AssignmentProcessApi.Models;

namespace CM.Services.AssignmentProcessApi.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<AssignmentProcessDto>> GetAssignments();
        Task<AssignmentProcessDto> GetAssignmentById(Guid AssignmentId);
        Task<IEnumerable<AssignmentProcessDto> >GetAssignmentsByCustomerName(string CustomertName);
        Task<IEnumerable<AssignmentProcessDto>> GetAssignmentsByConsultantName(string ConsultantName);
        Task<IEnumerable<AssignmentProcessDto>> GetAssignmentsByBrokerName(string BrokerName);

        Task<AssignmentProcessDto> CreateUpdateAssignment(AssignmentProcessDto AssignmentDto);
        Task<bool> DeleteAssignment(Guid AssignmentId);
    }
}
