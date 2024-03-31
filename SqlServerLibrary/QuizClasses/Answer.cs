using SqlServerLibrary.Context;
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
        [Key]
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public DateTime CreateDate { get; set; }


        // Foreign keys
        public int QuestionId { get; set; }

        // Navigation properties       
        public Question Question { get; set; } 
        
        public static void SaveToAnswersList(string answerText, int questionId)
        {
            using (var db = new QuizDBContext())
            {               

                Answer newAnswer = new Answer
                {
                    AnswerText = answerText,
                    CreateDate = DateTime.Now,
                    QuestionId = questionId
                };
                db.Answers.Add(newAnswer);
                db.SaveChanges();
            }
        }
    }
}
