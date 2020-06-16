﻿using System;
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

namespace CipherBreaker
{
    /// <summary>
    /// DecodePage.xaml 的交互逻辑
    /// </summary>
    public partial class DecodePage : Page
    {
        public DecodePage(Task task)
        {
            InitializeComponent();
            this.task = task;
            this.scheme = Scheme.NewScheme(task.type, task.OriginText, task.ResultText, task.Key);
        }

        private Task task;
        private Scheme scheme;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            bool ok;
            (Result.Text, ok) = scheme.Decode(scheme.Cipher, task.Key);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
