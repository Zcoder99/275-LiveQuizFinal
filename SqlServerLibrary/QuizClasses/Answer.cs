using SqlServerLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerLibrary.QuizClasses
{
    public class Answer
    {
        public int Id { get; set; } // get and set the answer id
        public string AnswerText { get; set; } // get and set the answer text
        public DateTime CreateDate { get; set; } // logs the creation date of the answer

        // Foreign keys
        public int QuestionId { get; set; } // get and set the question id
        public int UserId { get; set; } // get and set the user id

        // Navigation properties
        public Question Question { get; set; } // navigation property for question class
        public User User { get; set; } // navigation property for user class
    }
}
