using SqlServerLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerLibrary.QuizClasses
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public DateTime CreateDate { get; set; }


        // Foreign keys
        public int QuestionId { get; set; }

        // Navigation properties       
        public Question Question { get; set; }


        
    }
}
