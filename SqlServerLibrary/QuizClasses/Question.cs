using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlServerLibrary.QuizClasses;
using SqlServerLibrary.UserClasses;

namespace SqlServerLibrary
{
    public class Question
    {
        // Question properties
        public int QuestionId { get; set; } // get and set the question id
        public string QuestionText { get; set; } // get and set the question text
        public DateTime CreateDate { get; set; } // logs the creation date of the question  
        public List<Answer> Answers { get; set; } // get and set the answers to the question

        // Navigation property for associated quiz
        public Quiz Quiz { get; set; }

        // Navigation property for associated user
        public User User { get; set; }
        public object QuizId { get; set; }
    }
}
