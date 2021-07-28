using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizApplication.Common.ServiceModels;
using QuizApplication.Data;
using QuizApplication.Models;
using QuizApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApplication.Services.Implementations
{
    public class QuizService : DataService, IQuizService
    {
        private readonly IMapper mapper;

        public QuizService(QuizDbContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }

        public async Task CreateQuiz(Quiz quiz)
        {
            await context.Quizzes.AddAsync(quiz);
            await context.SaveChangesAsync();
        }

        public async Task DeleteQuiz(int id)
        {
            var quiz = await context.Quizzes.Include(q => q.QuizQuestions).FirstOrDefaultAsync(q => q.Id == id);

            if (quiz == null)
            {
                return;
            }

            context.Quizzes.Remove(quiz);
            context.Questions.RemoveRange(quiz.QuizQuestions);
            await context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Quiz>> AllQuizzes()
        {
            var quizzes = await context.Quizzes.Include(q => q.QuizQuestions).ToListAsync();

            return quizzes;
        }

        public async Task<Quiz> GetQuizById(int id)
        {
            var quiz = await context.Quizzes
                .Include(q => q.QuizQuestions.OrderBy(q => Guid.NewGuid()).Take(10))
                .FirstOrDefaultAsync(q => q.Id == id);

            return quiz;
        }

        public async Task StartQuiz(QuizServiceModel model, string username)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            var quiz = await context.Quizzes.Include(q => q.QuizQuestions).FirstOrDefaultAsync(q => q.Id == model.Id);
            var questions = new List<Question>();
            foreach (var answer in model.Answers)
            {
                var question = await context.Questions.Where(q => q.Id == answer.QuestionId).FirstOrDefaultAsync();
                questions.Add(question);

            }

            if (user == null || quiz == null)
            {
                return;
            }

            var results = new UserResult();
            results.UserId = user.Id;
            results.User = user;
            results.QuizId = quiz.Id;
            results.Quiz = quiz;

            model.Result = results;

            for (int i = 0; i < questions.Count; i++)
            {
                var questionId = questions[i].Id;
                var correctAnswer = questions[i].CorrectAnswer;
                var currentAnswer = model.Answers.FirstOrDefault(x => x.QuestionId == questionId).Answer;

                var result = currentAnswer == correctAnswer ? model.Result.UsersCorrectAnswers++ : model.Result.UsersWrongAnswers++;
            }

            model.Result.PointsEarned = model.Result.UsersCorrectAnswers;
            user.TotalQuizPoints += model.Result.PointsEarned;

            await context.UserResults.AddAsync(model.Result);

            await context.SaveChangesAsync();
        }

        public async Task<List<Quiz>> GetSearchingResults(string searchTerm)
        {
            return await context.Quizzes
                .Where(q => q.Name.Contains(searchTerm))
                .Include(q => q.QuizQuestions)
                .OrderByDescending(q => q.Name)
                .ThenByDescending(q => q.QuizQuestions.Count())
                .ToListAsync();
        }
    }
}
