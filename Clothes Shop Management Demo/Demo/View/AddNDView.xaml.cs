﻿using Demo.ViewModel;
using Microsoft.Win32;
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

namespace Demo.View
{
    /// <summary>
    /// Interaction logic for AddNVView.xaml
    /// </summary>
    public partial class AddNDView : Page
    {
        public AddNDView()
        {
            InitializeComponent();
        }
        private void lbl_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.MainFrame.Content = new QLNVView();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {
                HinhAnh1.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
    }
}
