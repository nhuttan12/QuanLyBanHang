﻿using Demo.Model;
using Demo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Demo.ViewModel
{
    internal class PrintOrderViewModel: BaseViewModel
    {
        private ObservableCollection<KHACHHANG> _listKH;
        public ObservableCollection<KHACHHANG> listKH { get => _listKH; set { _listKH = value; OnPropertyChanged(); } }
        public ICommand PrintCM { get; set; }
        private ObservableCollection<string> _listTK;
        public ObservableCollection<string> listTK { get => _listTK; set { _listTK = value; OnPropertyChanged(); } }
        public PrintOrderViewModel()
        {
            listKH = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANGs);
            listTK = new ObservableCollection<string>() { "Họ tên", "Địa Chỉ", "SĐT" };
            PrintCM = new RelayCommand<PrintOrderView>((p) => { return p == null ? false : true; }, (p) => _Print(p));
        }
        void _Print(PrintOrderView parameter)
        {
            try
            {
                parameter.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog()==true)
                {
                    printDialog.PrintVisual(parameter.PrintOrderPage, "Hóa đơn");
                }
            }
            finally
            {
                parameter.IsEnabled = true;
            }
        }
    }
}
