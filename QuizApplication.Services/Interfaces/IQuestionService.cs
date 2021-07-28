using QuizApplication.Models;
using System.Threading.Tasks;

namespace QuizApplication.Services.Interfaces
{
    public interface IQuestionService
    {
        Task AddQuestion(Question question);
    }
}
