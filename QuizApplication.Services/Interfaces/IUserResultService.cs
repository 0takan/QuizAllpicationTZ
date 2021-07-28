using QuizApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApplication.Services.Interfaces
{
    public interface IUserResultService
    {
        Task<UserResult> GetUserResultById(int id, string username);

        Task<IEnumerable<UserResult>> GetAllUserResultsByUser(string username);
    }
}
