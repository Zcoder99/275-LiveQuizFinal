using Microsoft.EntityFrameworkCore;
using SqlServerLibrary.QuizClasses;
using SqlServerLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerLibrary
{
    public class QuizDBContext : DbContext
    {
        //dbset the tables
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AnonUser> AnonUsers { get; set; }

        // connect to the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=B231-7; Database=SqlLiveQuizFinal; User Id=sa; Password=P@ssword!; Encrypt=False;");
        }

        // Configure relationships quiz 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configure the relationship between the Quiz and Question tables
            modelBuilder.Entity<Quiz>().HasMany(q => q.Questions).WithOne(q => q.Quiz).HasForeignKey(q => q.QuizId);
            
            
            // questions have a one to many relationship with answers
            modelBuilder.Entity<Question>().HasMany(q => q.Answers).WithOne(a => a.Question).HasForeignKey(a => a.QuestionId);
            
            // users have a one to many relationship with quizzes
            modelBuilder.Entity<User>().HasMany(u => u.UsersQuizzes).WithOne(q => q.User).HasForeignKey(q => q.UserId);
        }
    }
}
