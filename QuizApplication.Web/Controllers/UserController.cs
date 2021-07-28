using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Common.ViewModels;
using QuizApplication.Services.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Ranklist()
        {
            var users = (await userService.GetUsersByTotalPoints())
                .Select(mapper.Map<UsersRanklistViewModel>);

            return View(users);
        }
    }
}