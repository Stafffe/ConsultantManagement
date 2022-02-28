using AutoMapper;
using CM.Services.AssignmentProcessApi.DbContexts;
using CM.Services.AssignmentProcessApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CM.Services.AssignmentProcessApi.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public Repository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<AssignmentProcessDto> CreateUpdateAssignment(AssignmentProcessDto AssignmentDto)
        {
            AssignmentProcess assignment = _mapper.Map<AssignmentProcessDto, AssignmentProcess>(AssignmentDto);
            if (assignment.AssignmentProcessId != Guid.Empty)
            {
                _db.Assignments.Update(assignment);
            }
            else
            {
                _db.Assignments.Add(assignment);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<AssignmentProcess, AssignmentProcessDto>(assignment);
        }

        public async Task<bool> DeleteAssignment(Guid AssignmentId)
        {
            try
            {
                AssignmentProcess assignment = await _db.Assignments.SingleOrDefaultAsync(u => u.AssignmentProcessId == AssignmentId);
                if (assignment == null)
                {
                    return false;
                }
                _db.Assignments.Remove(assignment);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<AssignmentProcessDto> GetAssignmentById(Guid AssignmentId)
        {
            AssignmentProcess assignment = await _db.Assignments.SingleOrDefaultAsync(a => a.AssignmentProcessId == AssignmentId);
            return _mapper.Map<AssignmentProcessDto>(assignment);
        }

        public async Task<IEnumerable<AssignmentProcessDto>> GetAssignments()
        {
            List<AssignmentProcess> assignmentList = await _db.Assignments.ToListAsync();
            return _mapper.Map<List<AssignmentProcessDto>>(assignmentList);
        }

        public async Task<IEnumerable<AssignmentProcessDto>> GetAssignmentsByBrokerName(string BrokerName)
        {
            List<AssignmentProcess> assignmentList = await _db.Assignments.Where(a => a.Brocker.Equals(BrokerName)).ToListAsync();
            return _mapper.Map<List<AssignmentProcessDto>>(assignmentList);
        }

        public async Task<IEnumerable<AssignmentProcessDto>> GetAssignmentsByConsultantName(string ConsultantName)
        {
            List<AssignmentProcess> assignmentList = await _db.Assignments.Where(a => a.Consultant.Equals(ConsultantName)).ToListAsync();
            return _mapper.Map<List<AssignmentProcessDto>>(assignmentList);
        }

        public async Task<IEnumerable<AssignmentProcessDto>> GetAssignmentsByCustomerName(string CustomertName)
        {
            List<AssignmentProcess> assignmentList = await _db.Assignments.Where(a => a.Customer.Equals(CustomertName)).ToListAsync();
            return _mapper.Map<List<AssignmentProcessDto>>(assignmentList);
        }
    }
}
