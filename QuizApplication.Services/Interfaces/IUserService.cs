using QuizApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<QuizUser>> GetUsersByTotalPoints();
    }
}
