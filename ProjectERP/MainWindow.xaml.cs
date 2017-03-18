﻿using System.Windows;
using ProjectERP.Services;

namespace ProjectERP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DatabaseAccessService _databaseService;
        public MainWindow()
        {
            InitializeComponent();
            _databaseService = new DatabaseAccessService();
        }
    }
}