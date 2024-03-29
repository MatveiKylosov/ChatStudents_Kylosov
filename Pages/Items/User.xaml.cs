﻿using ChatStudents_Kylosov.Classes.Common;
using ChatStudents_Kylosov.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatStudents_Kylosov.Pages.Items
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : UserControl
    {
        Users user;
        Main main;

        public User()
        {
            InitializeComponent();
        }

        public User(Users user, Main main, bool online)
        {
            InitializeComponent();
            this.user = user;
            this.main = main;
            imgUser.Source = BitmapFromArrayByte.LoadImage(user.Photo);
            FIO.Content = user.ToFIO() + $" ({(online ? "Online" : "Offline")})";
        }

        private void SelectChat(object sender, MouseButtonEventArgs e) => main.SelectUser(user);
    }
}
