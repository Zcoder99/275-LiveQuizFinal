using Microsoft.EntityFrameworkCore;
using SqlServerLibrary.QuizClasses;
using SqlServerLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SqlServerLibrary.Context
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
            // Quiz - question: one-to-many relationship
            modelBuilder.Entity<Quiz>()
                .HasMany(q => q.Questions)
                .WithOne(q => q.Quiz)
                .HasForeignKey(q => q.QuizId)
                .OnDelete(DeleteBehavior.Restrict);

            // Question - Answer: One-to-many relationship
            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            // User - Quiz: One-to-many relationship
            modelBuilder.Entity<User>()
                .HasMany(u => u.UsersQuizzes)
                .WithOne(q => q.User)
                .HasForeignKey(q => q.UserId)
                .OnDelete(DeleteBehavior.Restrict);

          

            modelBuilder.Entity<Question>()
                .HasIndex(q => q.UserId);
        }
    }
}
