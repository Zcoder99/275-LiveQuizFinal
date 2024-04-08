﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqlServerLibrary.Context;

#nullable disable

namespace SqlServerLibrary.Migrations
{
    [DbContext(typeof(QuizDBContext))]
    [Migration("20240408162528_Added correct answer property")]
    partial class Addedcorrectanswerproperty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SqlServerLibrary.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsMultipleChoice")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrueFalse")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("SqlServerLibrary.QuizClasses.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CorrectAnswer")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("SqlServerLibrary.QuizClasses.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuizName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("SqlServerLibrary.UserClasses.AnonUser", b =>
                {
                    b.Property<int>("AnonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnonId"));

                    b.Property<string>("AnonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnonId");

                    b.ToTable("AnonUsers");
                });

            modelBuilder.Entity("SqlServerLibrary.UserClasses.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<bool>("Access")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SqlServerLibrary.UserClasses.UserQuiz", b =>
                {
                    b.Property<int>("UserQuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserQuizId"));

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserQuizId");

                    b.HasIndex("QuizId");

                    b.HasIndex("UserId");

                    b.ToTable("UserQuiz");
                });

            modelBuilder.Entity("SqlServerLibrary.Question", b =>
                {
                    b.HasOne("SqlServerLibrary.QuizClasses.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("SqlServerLibrary.QuizClasses.Answer", b =>
                {
                    b.HasOne("SqlServerLibrary.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SqlServerLibrary.UserClasses.UserQuiz", b =>
                {
                    b.HasOne("SqlServerLibrary.QuizClasses.Quiz", "Quiz")
                        .WithMany("UserQuizzes")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SqlServerLibrary.UserClasses.User", "User")
                        .WithMany("UsersQuizzes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Quiz");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SqlServerLibrary.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("SqlServerLibrary.QuizClasses.Quiz", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("UserQuizzes");
                });

            modelBuilder.Entity("SqlServerLibrary.UserClasses.User", b =>
                {
                    b.Navigation("UsersQuizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
