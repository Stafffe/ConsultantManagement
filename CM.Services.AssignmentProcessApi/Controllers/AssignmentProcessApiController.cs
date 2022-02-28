using CM.Services.AssignmentProcessApi.Models;
using CM.Services.AssignmentProcessApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CM.Services.AssignmentProcessApi.Controllers
{
    [Route("api/AssignmentProcess")]

    public class AssignmentProcessApiController : ControllerBase
    {
        protected ResponseDto _response;
        private IRepository _repository;
        public AssignmentProcessApiController(IRepository repository)
        {
            this._repository = repository;
            _response = new ResponseDto();
        }
        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            try
            {
                IEnumerable<AssignmentProcessDto> AssignmentDtos = await _repository.GetAssignments();
                _response.Result = AssignmentDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ResponseDto> Get(Guid id)
        {
            try
            {
                AssignmentProcessDto AssignmentDto = await _repository.GetAssignmentById(id);
                _response.Result = AssignmentDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        [HttpGet]
        [Route("GetByCustomerName{customerName}")]
        public async Task<ResponseDto> GetByCustomerName(string customerName)
        {
            try
            {
                IEnumerable<AssignmentProcessDto> assignmentDtos = await _repository.GetAssignmentsByCustomerName(customerName);
                _response.Result = assignmentDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [HttpGet]
        [Route("GetByConsultantName{consultantName}")]
        public async Task<ResponseDto> GetByConsultantName(string consultantName)
        {
            try
            {
                IEnumerable<AssignmentProcessDto> assignmentDtos = await _repository.GetAssignmentsByConsultantName(consultantName);
                _response.Result = assignmentDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
      
        [HttpGet]
        [Route("GetByBrokerName{brokerName}")]
        public async Task<ResponseDto> GetByBrokerName(string brokerName)
        {
            try
            {
                IEnumerable<AssignmentProcessDto> assignmentDtos = await _repository.GetAssignmentsByBrokerName(brokerName);
                _response.Result = assignmentDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] AssignmentProcessDto AssignmentDto)
        {
            try
            {
                AssignmentProcessDto model = await _repository.CreateUpdateAssignment(AssignmentDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        [HttpPut]
        public async Task<ResponseDto> Put([FromBody] AssignmentProcessDto AssignmentDto)
        {
            try
            {
                AssignmentProcessDto model = await _repository.CreateUpdateAssignment(AssignmentDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ResponseDto> Delete(Guid id)
        {
            try
            {
                bool isSuccess = await _repository.DeleteAssignment(id);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
