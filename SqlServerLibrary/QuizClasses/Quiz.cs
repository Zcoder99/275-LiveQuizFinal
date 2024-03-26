using SqlServerLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerLibrary.QuizClasses
{
    public class Quiz
    {
        // Quiz properties
        public int Id { get; set; }// get and set the quiz id
        public string QuizName { get; set; }// get and set the quiz name
        public DateTime CreateDate { get; set; }// logs the creation date of the quiz

        public List<Question> Questions { get; set; } // navigation property for question class
        public List<UserQuiz> UserQuizzes { get; set; }

        // Navigation property for associated user
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
