using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using QuizApplication.Common.ServiceModels;
using QuizApplication.Common.ViewModels;
using QuizApplication.Models;
using QuizApplication.Services.Interfaces;
using QuizApplication.Web.Hubs;
using System.Threading.Tasks;

namespace QuizApplication.Web.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuizService quizService;
        private readonly IMapper mapper;
        private readonly IHubContext<NotificationHub> notificationHubContext;

        public QuizController(IQuizService quizService, IMapper mapper, IHubContext<NotificationHub> notificationHubContext)
        {
            this.quizService = quizService;
            this.mapper = mapper;
            this.notificationHubContext = notificationHubContext;

        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult CreateQuiz()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateQuiz(CreateQuizBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var quiz = mapper.Map<Quiz>(model);

            await quizService.CreateQuiz(quiz);

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteQuiz(int id)
        {
            await quizService.DeleteQuiz(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> StartQuiz(int id)
        {
            var getQuiz = await quizService.GetQuizById(id);

            var quiz = mapper.Map<QuizViewModel>(getQuiz);

            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        [HttpPost]
        public async Task<IActionResult> StartQuiz(QuizViewModel model)
        {
            var quiz = mapper.Map<QuizServiceModel>(model);

            await quizService.StartQuiz(quiz, User.Identity.Name);

            await notificationHubContext.Clients.All.SendAsync("sendNotification");

            return RedirectToAction("Result", "UserResult", new { id = quiz.Result.Id });
        }

        public async Task<IActionResult> SearchResults(string searchTerm)
        {
            if (searchTerm == null)
            {
                return NotFound();
            }

            var foundQuizzes = await quizService.GetSearchingResults(searchTerm);

            var result = new SearchResultsViewModel();
            result.SearchTerm = searchTerm;
            result.Quizzes = foundQuizzes;

            return View(result);
        }

    }
}