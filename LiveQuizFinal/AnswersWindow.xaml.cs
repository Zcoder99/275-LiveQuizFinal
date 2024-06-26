﻿using SqlServerLibrary.QuizClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SqlServerLibrary;
using SqlServerLibrary.Context;

namespace LiveQuizFinal
{
    /// <summary>
    /// Interaction logic for AnswersWindow.xaml
    /// </summary>
    public partial class AnswersWindow : Window
    {
        private int questionId; // Store reference to the quiz

        public AnswersWindow(int questionId) 
        {
            InitializeComponent();
            this.questionId = questionId; // Assign the passed quiz object to the local variable
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string answerText = txtAnswer.Text.Trim(); // Get the answer text                     

            if (string.IsNullOrWhiteSpace(answerText)) // Check if the answer text is empty
            {
                MessageBox.Show("Please enter a answer for your quesiton");
                return;
            }


            // Check for existing correct answers for true/false questions
            if(Answer.CheckExistingCorrectAnswers(questionId, cb_corectAnswer.IsChecked == true))
            {
                return; // Exit the method without saving the answer
            }


            Answer.SaveToAnswersList(answerText, questionId, cb_corectAnswer.IsChecked == true); // Save the answer to the database

            MessageBox.Show("Answer added to the question"); // Provide feedback to the user

            txtAnswer.Text = ""; // Clear the text box
        }        
    }
}
