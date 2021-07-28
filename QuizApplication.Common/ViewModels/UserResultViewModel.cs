using QuizApplication.Models;

namespace QuizApplication.Common.ViewModels
{
    public class UserResultViewModel
    {

        public QuizUser User { get; set; }

        public Quiz Quiz { get; set; }

        public int UsersCorrectAnswers { get; set; }

        public int UsersWrongAnswers { get; set; }

        public int PointsEarned { get; set; }
    }
}
