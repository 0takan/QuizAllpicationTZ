using AutoMapper;
using QuizApplication.Common.ServiceModels;
using QuizApplication.Common.ViewModels;
using QuizApplication.Models;

namespace QuizApplication.Common.Mapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Quiz, CreateQuizBindingModel>().ReverseMap();
            CreateMap<Quiz, QuizViewModel>().ReverseMap();
            CreateMap<Quiz, AllQuizzesViewModel>().ReverseMap();
            CreateMap<Quiz, SearchResultsViewModel>().ReverseMap();
            CreateMap<Question, QuestionViewModel>().ReverseMap();
            CreateMap<Question, AddQuestionBindingModel>().ReverseMap();
            CreateMap<UserResult, UserResultViewModel>().ReverseMap();
            CreateMap<QuizUser, UsersRanklistViewModel>().ReverseMap();
            CreateMap<QuizServiceModel, QuizViewModel>().ReverseMap();
            CreateMap<AnswersServiceModel, AnswersBindingModel>().ReverseMap();
        }
    }
}
