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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ConsoleApp1;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Restaurant> restaurants;
        public MainWindow()
        {
            InitializeComponent();
           restaurants = JSONParser.ParsIt();
            cmdAnswer_Click(restaurants);
        }
        
    private void cmdAnswer_Click(object sender)
        {
            txtAnswer.Text = restaurants[0]._address;
            this.Cursor = null;
        }


    }
}
