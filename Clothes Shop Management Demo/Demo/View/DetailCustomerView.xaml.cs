﻿using Demo.ViewModel;
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

namespace Demo.View
{
    /// <summary>
    /// Interaction logic for DetailCustomerView.xaml
    /// </summary>
    public partial class DetailCustomerView : Page
    {
        public DetailCustomerView()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
        private void lbl_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.MainFrame.Content = new CustomersView();
        }
    }
}
