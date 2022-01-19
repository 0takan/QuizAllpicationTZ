using QuizApplication.Common.ServiceModels;
using QuizApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApplication.Services.Interfaces
{
    public interface IQuizService
    {
        Task CreateQuiz(Quiz     quiz);

        Task DeleteQuiz(int id);

        Task<IEnumerable<Quiz>> AllQuizzes();

        Task<Quiz> GetQuizById(int id);

        Task StartQuiz(QuizServiceModel model, string username);

        Task<List<Quiz>> GetSearchingResults(string searchTerm);
    }
}
