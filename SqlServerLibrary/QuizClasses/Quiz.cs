using SqlServerLibrary.Context;
using SqlServerLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SqlServerLibrary.QuizClasses
{
    public class Quiz
    {

        public Quiz()
        {
            // initialize the list of questions
            Questions = new List<Question>();
        }

        // Quiz properties
        public int Id { get; set; }// get and set the quiz id
        public string QuizName { get; set; }// get and set the quiz name
        public DateTime CreateDate { get; set; }// logs the creation date of the quiz

        public List<Question> Questions { get; set; } // navigation property for question class
        public List<UserQuiz> UserQuizzes { get; set; }

       

        // write method to save quiz to the database
        public void SaveToDatabase(Quiz newQuiz)
        {
            try
            {
                using (var context = new QuizDBContext())
                {
                    context.Quizzes.Add(newQuiz);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving quiz to database: {ex.Message}");
            }

        }
    }
}
