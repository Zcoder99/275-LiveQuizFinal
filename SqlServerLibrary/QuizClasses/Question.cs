using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using SqlServerLibrary.Context;
using SqlServerLibrary.QuizClasses;
using SqlServerLibrary.UserClasses;
using static System.Net.Mime.MediaTypeNames;

namespace SqlServerLibrary
{
    public class Question
    {
        // add bool propertys T or F questions and Multiple choice 


        [Key]
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public DateTime CreateDate { get; set; }

        // Navigation properties
        public List<Answer> Answers { get; set; }
        public Quiz Quiz { get; set; }


        [Required]
        public int QuizId { get; set; }

        //Save changes to the database.
        public void SaveToQuestionsList(string text, int quizId)
        {
            try
            {
                using (var db = new QuizDBContext())
                {

                    // Create a new instance of the Question class and set its properties
                    var newQuestion = new Question
                    {
                        QuestionText = text,
                        QuizId = quizId // Assign the quiz id to the new question
                    };

                    // Add the new question to the database context
                    db.Questions.Add(newQuestion);
                    
                    // Save the changes to the database
                    db.SaveChanges();
                }            
            }
            catch(Exception ex)
            {

                MessageBox.Show($"Error saving question to the database: {ex.Message}");
            }

        }
    }
}
