using CM.Web.Models;
using CM.Web.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CM.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAssignmentProcessService processService; 
        public HomeController(ILogger<HomeController> logger, IAssignmentProcessService assignmentProcessService)
        {
            _logger = logger;
            processService=assignmentProcessService;
        }

        public async Task<IActionResult> Index()
        {
            List<AssignmentProcessDto> list = new();
            var response = await processService.GetAllAssignmentProcessesAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<AssignmentProcessDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

        [Authorize]
        public async Task<IActionResult> Details(Guid assignmentProcessId)
        {
            AssignmentProcessDto assignment = new();
            var response = await processService.GetAssignmentProcessByIdAsync<ResponseDto>(assignmentProcessId);
            if (response != null && response.IsSuccess)
            {
                assignment = JsonConvert.DeserializeObject<AssignmentProcessDto>(Convert.ToString(response.Result));
            }
            return View(assignment);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Authorize]
        public async Task<IActionResult> Login()
        {

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}