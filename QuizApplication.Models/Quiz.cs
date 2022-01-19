using QuizApplication.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuizApplication.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descritpion { get; set; }

        public Category Category { get; set; }

        public List<Question> QuizQuestions { get; set; } = new List<Question>();

        public string QuizLogoUrl { get; set; }

    }
}
