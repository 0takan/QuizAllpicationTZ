using QuizApplication.Data;
using QuizApplication.Models;
using QuizApplication.Services.Interfaces;
using System.Threading.Tasks;

namespace QuizApplication.Services.Implementations
{
    public class QuestionService : DataService, IQuestionService
    {
        public QuestionService(QuizDbContext context) : base(context)
        {
        }

        public async Task AddQuestion(Question question)
        {
            if (question.CorrectAnswer == question.FirstOption || question.CorrectAnswer == question.SecondOption ||
                question.CorrectAnswer == question.ThirdOption || question.CorrectAnswer == question.FourthOption)
            {
                await context.Questions.AddAsync(question);
            }
            else
            {
                return;
            }

            await context.SaveChangesAsync();
        }
    }
}
