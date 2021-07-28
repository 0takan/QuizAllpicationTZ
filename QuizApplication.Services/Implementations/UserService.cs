using Microsoft.EntityFrameworkCore;
using QuizApplication.Data;
using QuizApplication.Models;
using QuizApplication.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Services.Implementations
{
    public class UserService : DataService, IUserService
    {
        public UserService(QuizDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<QuizUser>> GetUsersByTotalPoints()
        {
            var users = await context.Users
                .OrderByDescending(u => u.TotalQuizPoints)
                .ThenByDescending(u => u.TotalAchievementPoints)
                .ToListAsync();

            return users;
        }
    }
}
