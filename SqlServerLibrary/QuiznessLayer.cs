using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SqlServerLibrary.Context;
using SqlServerLibrary.QuizClasses;

namespace SqlServerLibrary
{
    public class QuiznessLayer
    {
        // Method to get quiz including questions and answers
        public  List<Quiz> GetQuizWithQuestionsAndAnswers()
        {
            using (var db = new QuizDBContext())
            {
                // Use the Include method to load related entities
                return db.Quizzes.Include(q => q.Questions)
                    .ThenInclude(a => a.Answers).ToList();
            }
        }      
    }
}
