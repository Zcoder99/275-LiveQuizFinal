using SqlServerLibrary.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SqlServerLibrary.QuizClasses
{
    public class Answer
    {       
        [Key]
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool CorrectAnswer { get; set; }
        public DateTime CreateDate { get; set; }


        // Foreign keys
        public int QuestionId { get; set; }

        // Navigation properties       
        public Question Question { get; set; } 
        
        public static void SaveToAnswersList(string answerText, int questionId, bool isCorrect)
        {
            using (var db = new QuizDBContext())
            {               

                Answer newAnswer = new Answer
                {
                    AnswerText = answerText,
                    CreateDate = DateTime.Now,
                    QuestionId = questionId,
                    CorrectAnswer = isCorrect
                    
                };
                db.Answers.Add(newAnswer);
                db.SaveChanges();
            }
        }

        public static bool CheckExistingCorrectAnswers(int questionId, bool isCorrectChecked)
        {
            // Find the answer corresponding to the current question
            using (var db = new QuizDBContext())
            {
                var question = db.Questions.FirstOrDefault(q => q.Id == questionId);
                if (question != null && question.IsTrueFalse)
                {
                    // For true or false questions, check if there is already a correct answer set
                    var existingCorrectAnswer = db.Answers.FirstOrDefault(a => a.QuestionId == questionId && a.CorrectAnswer);
                    if (existingCorrectAnswer != null)
                    {
                        if (isCorrectChecked)
                        {
                            MessageBox.Show("A correct answer is already set for this true/false question.");
                            return true; // Exit the method without saving the answer
                        }
                    }
                }
            }
            return false;
        }
    }
}
