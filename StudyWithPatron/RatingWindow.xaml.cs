﻿using System;
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
using StudyWithPatron.BLL;
using StudyWithPatron.DAL;
namespace StudyWithPatron
{
    /// <summary>
    /// Interaction logic for RatingWindow.xaml
    /// </summary>
    public partial class RatingWindow : Window
    {
        public RatingWindow()
        {
            InitializeComponent();
        }
        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow reg_win = new RegistrationWindow();
            this.Visibility = Visibility.Hidden;
            reg_win.Show();
        }
    }
}