using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace QuizApplication.Models
{
    // Add profile data for application users by adding properties to the QuizaldoUser class
    public class QuizUser : IdentityUser
    {
        public string Name { get; set; }

        public int TotalQuizPoints { get; set; }

        public int TotalAchievementPoints { get; set; }

        public List<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();
    }
}
