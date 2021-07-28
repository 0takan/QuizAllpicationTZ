using QuizApplication.Models;
using System.Collections.Generic;

namespace QuizApplication.Common.ViewModels
{
    public class SearchResultsViewModel
    {
        public List<Quiz> Quizzes { get; set; }

        public string SearchTerm { get; set; }
    }
}
