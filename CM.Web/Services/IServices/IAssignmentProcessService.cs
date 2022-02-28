using CM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CM.Web.Services.IServices
{
    public interface IAssignmentProcessService : IBaseService
    {
        Task<T> GetAllAssignmentProcessesAsync<T>();
        Task<T> GetAssignmentProcessByIdAsync<T>(Guid id);
        Task<T> CreateAssignmentProcessAsync<T>(AssignmentProcessDto assignmentProcessDto);
        Task<T> UpdateAssignmentProcessAsync<T>(AssignmentProcessDto assignmentProcessDto);
        Task<T> DeleteAssignmentProcessAsync<T>(Guid id);
    }
}
