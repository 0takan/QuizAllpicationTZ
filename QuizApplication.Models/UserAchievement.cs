using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplication.Models
{
    public class UserAchievement
    {
        public string UserId { get; set; }

        public QuizUser User { get; set; }

        public int AchievementId { get; set; }

        public Achievement Achievement { get; set; }

        public DateTime AchievedOn { get; set; }
    }
}
