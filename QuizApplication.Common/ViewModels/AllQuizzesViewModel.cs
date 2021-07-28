using QuizApplication.Models;
using QuizApplication.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplication.Common.ViewModels
{
    public class AllQuizzesViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public string QuizLogoUrl { get; set; }

        public List<Question> QuizQuestions { get; set; }
    }
}
