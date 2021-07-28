using QuizApplication.Models;
using QuizApplication.Models.Enums;
using System.Collections.Generic;

namespace QuizApplication.Common.ViewModels
{
    public class QuizViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }

        public string QuizLogoUrl { get; set; }

        public ICollection<QuestionViewModel> QuizQuestions { get; set; }


        public List<AnswersBindingModel> Answers { get; set; }

        public UserResult Result { get; set; }

    }
}
