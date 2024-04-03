﻿using SqlServerLibrary;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuiznessLayer quiznessLayer = new QuiznessLayer();
        public MainWindow()
        {
            InitializeComponent();
            var quizzes = quiznessLayer.GetQuizWithQuestionsAndAnswers();
        }
        
        
    }
}