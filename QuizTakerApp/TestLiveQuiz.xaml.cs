using MaterialDesignThemes.Wpf.Transitions;
using SqlServerLibrary.QuizClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for TestLiveQuiz.xaml
    /// </summary>
    public partial class TestLiveQuiz : Window
    {
        public Quiz SelectedQuiz { get; set; } // access to selected quiz

        public TestLiveQuiz(Quiz selectedQuiz)
        {
            InitializeComponent();
            SelectedQuiz = selectedQuiz; // set the selected quiz

            

            

            foreach (var question in SelectedQuiz.Questions)
            {
               
                

                // create a new instance of the TestControl
                TestControl questionControl = new TestControl(question);

                // create a transitionerSilde for the control
                var slide = new TransitionerSlide();
                slide.Content = questionControl;
               
                // get the test of the current question
                questionControl.QuestionText = question.QuestionText;

                // add the testcontrol to the first row of the grid
                Grid.SetRow(slide, 0);
                // Add the transitionerSlide to the transitioner                
                TransitionerControl.Items.Add(slide);
            }
           // Display the first question
            TransitionerControl.SelectedIndex = 0;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the current slide
            var currentSlide = TransitionerControl.SelectedItem;
            // Get the index of the current slide
            var currentIndex = TransitionerControl.Items.IndexOf(currentSlide);
            // Get the previos slide
            var previousSlide = TransitionerControl.Items[currentIndex - 1];
            // Set the previous slide as the selected slide
            TransitionerControl.SelectedItem = previousSlide;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Get the current slide
            var currentSlide = TransitionerControl.SelectedItem;
            // Get the index of the current slide
            var currentIndex = TransitionerControl.Items.IndexOf(currentSlide);
            // Get the next slide
            var nextSlide = TransitionerControl.Items[currentIndex + 1];
            // Set the next slide as the selected slide
            TransitionerControl.SelectedItem = nextSlide;

        }
    }
}
