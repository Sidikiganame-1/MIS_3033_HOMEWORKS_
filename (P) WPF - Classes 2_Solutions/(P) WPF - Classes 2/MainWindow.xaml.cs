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

namespace _P__WPF___Classes_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Toy toy = new Toy();
            
            toy.Manufacturer = Manufact.Text;
            toy.Name = Name.Text;
            toy.Price = Convert.ToDouble(Price.Text);

            LB.Items.Add(toy.Manufacturer);

           Toy selectedToy = (Toy)ListToys.SelectedItem;

        }
    }
}
