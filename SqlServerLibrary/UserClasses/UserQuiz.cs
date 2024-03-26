using SqlServerLibrary.QuizClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerLibrary.UserClasses
{
    public class UserQuiz
    {
        [Key] 
        public int UserQuizId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
