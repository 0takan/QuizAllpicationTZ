using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Common.ViewModels;
using QuizApplication.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Web.Controllers
{
    [Authorize]
    public class UserResultController : Controller
    {
        private readonly IUserResultService userResultService;
        private readonly IMapper mapper;

        public UserResultController(IUserResultService userResultService, IMapper mapper)
        {
            this.userResultService = userResultService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Result(int id)
        {
            var getUserResult = await userResultService.GetUserResultById(id, User.Identity.Name);

            var userResult = mapper.Map<UserResultViewModel>(getUserResult);

            try
            {
                if (userResult.User == null)
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {

                return NotFound();
            }

            return View(userResult);
        }

        public async Task<IActionResult> MyResults(string username)
        {
            var userResults = (await userResultService.GetAllUserResultsByUser(User.Identity.Name))
                .Select(mapper.Map<UserResultViewModel>);

            return View(userResults);
        }
    }
}