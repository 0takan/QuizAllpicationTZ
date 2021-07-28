using QuizApplication.Models;
using System.Collections.Generic;

namespace QuizApplication.Common.ServiceModels
{
    public class QuizServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string QuizLogoUrl { get; set; }

        public ICollection<Question> QuizQuestions { get; set; }

        public List<AnswersServiceModel> Answers { get; set; }

        public UserResult Result { get; set; }
    }
}
