﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

namespace Bolhaya_pachka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MaterialsPage());
            Manager.MainFrame = MainFrame;
            //ImportSupplier();
        }

        private void Material_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MaterialsPage());
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack) { Back_button.Visibility = Visibility.Visible; }
            else Back_button.Visibility = Visibility.Hidden;
        }

        private void ImportSupplier()
        {
            var fileData = File.ReadAllLines(@"\\FSProfile1.biik.ad.biik.ru\Redirect\zverev\Desktop\Вариант 1\Сессия 1\supplier_k_import.txt");

            foreach (var line in fileData)
            {
                var data = line.Split(',');
                var tempSupplier = new Supplier
                {
                    name = data[0],
                    type = data[1].Replace(" ",""),
                    INN = data[2].Replace(" ",""), 
                    rating = int.Parse(data[3].Replace(" в рейтинге", "").Replace("Рейтинг = ", "").Replace(" ", "")),
                    start_data = DateTime.Parse(String.Format("{0:dd-MM-yyyy}", data[4].Replace(" ", "")))

                };

                Entities.GetContext().Suppliers.Add(tempSupplier);
                Entities.GetContext().SaveChanges();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
