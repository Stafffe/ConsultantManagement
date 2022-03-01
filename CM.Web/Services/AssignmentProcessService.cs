using CM.Web.Models;
using CM.Web.Services.IServices;

namespace CM.Web.Services
{
    public class AssignmentProcessService : BaseService, IAssignmentProcessService
    {
        private readonly IHttpClientFactory _clientFactory;

        public AssignmentProcessService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateAssignmentProcessAsync<T>(AssignmentProcessDto assignmentProcessDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = assignmentProcessDto,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess",
            });
        }

        public async Task<T> DeleteAssignmentProcessAsync<T>(Guid id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess/" + id,
            });
        }

        public async Task<T> GetAllAssignmentProcessesAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess",
            });
        }

        public async Task<T> GetAssignmentProcessByIdAsync<T>(Guid id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess/" + id,
            });
        }

        public async Task<T> UpdateAssignmentProcessAsync<T>(AssignmentProcessDto assignmentProcessDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = assignmentProcessDto,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess",
            });
        }


        public async Task<T> GetAssignmentProcessByCustomerNameAsync<T>(string customerName)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess/GetByCustomerName" + customerName,
            });
        }
        public async Task<T> GetAssignmentProcessByConsultantNameAsync<T>(string consultantName)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess/GetByConsultantName" + consultantName,
            });
        }
        public async Task<T> GetAssignmentProcessByBrokerAsync<T>(string brokerName)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.AssignmentProcessAPIBase + "/api/AssignmentProcess/GetByBrokerName" + brokerName,
            });
        }

    }
}
