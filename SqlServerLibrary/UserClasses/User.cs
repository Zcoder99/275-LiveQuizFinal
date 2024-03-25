using SqlServerLibrary.QuizClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerLibrary.UserClasses
{
    public class User
    {
        
        public int UserId { get; set; }// get and set the user id
        public string UserName { get; set; }// get and set the username
        public string Password { get; set; }// get and set the password
        public bool Access { get; set; }// get and set the access to the quiz


        // navigation property for quiz class
        public List<Quiz> UsersQuizzes { get; set; }

    }
}
