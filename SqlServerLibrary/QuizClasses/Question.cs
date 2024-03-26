using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlServerLibrary.QuizClasses;
using SqlServerLibrary.UserClasses;

namespace SqlServerLibrary
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public DateTime CreateDate { get; set; }

        // Navigation properties
        public List<Answer> Answers { get; set; }
        public Quiz Quiz { get; set; }
        public User User { get; set; } // This was missing in your original class
        [Required]
        public int QuizId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
