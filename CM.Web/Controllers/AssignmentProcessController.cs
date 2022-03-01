using CM.Web.Models;
using CM.Web.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CM.Web.Controllers
{
    public class AssignmentProcessController : Controller
    {
        private readonly IAssignmentProcessService _assignmentProcessService;
        public AssignmentProcessController(IAssignmentProcessService assignmentProcessService)
        {
            _assignmentProcessService = assignmentProcessService;
        }

        public async Task<IActionResult> AssignmentProcessIndex()
        {
            List<AssignmentProcessDto> list = new();
            var response = await _assignmentProcessService.GetAllAssignmentProcessesAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<AssignmentProcessDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
 
        public async Task<IActionResult> AssignmentProcessCreate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignmentProcessCreate(AssignmentProcessDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _assignmentProcessService.CreateAssignmentProcessAsync<ResponseDto>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(AssignmentProcessIndex));
                }
            }
            return View(model);
        }
        public async Task<IActionResult> AssignmentProcessEdit(Guid assignmentProcessId)
        {
            var response = await _assignmentProcessService.GetAssignmentProcessByIdAsync<ResponseDto>(assignmentProcessId);
            if (response != null && response.IsSuccess)
            {
                AssignmentProcessDto model = JsonConvert.DeserializeObject<AssignmentProcessDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignmentProcessEdit(AssignmentProcessDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _assignmentProcessService.UpdateAssignmentProcessAsync<ResponseDto>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(AssignmentProcessIndex));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> AssignmentProcessDelete(Guid assignmentProcessId)
        {
            var response = await _assignmentProcessService.GetAssignmentProcessByIdAsync<ResponseDto>(assignmentProcessId);
            if (response != null && response.IsSuccess)
            {
                AssignmentProcessDto model = JsonConvert.DeserializeObject<AssignmentProcessDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignmentProcessDelete(AssignmentProcessDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _assignmentProcessService.DeleteAssignmentProcessAsync<ResponseDto>(model.AssignmentProcessId);
                if (response.IsSuccess)
                {
                    return RedirectToAction(nameof(AssignmentProcessIndex));
                }
            }
            return View(model);
        }
    }
}
