﻿using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using System.Windows;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomerView : Window
    {

        CustomerViewModel _vm;
        public CustomerView(CustomerViewModel vm)
        {
            InitializeComponent();

            _vm = vm;
            DataContext = vm;
        }

        private void CustomerNew_Click(object sender, RoutedEventArgs e)
        {
            Customer tmp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            _vm.Customers.Add(tmp);
            _vm.SelectedCustomer = tmp;
        }

        private void CustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            int currentIndex = _vm.Customers.IndexOf(_vm.SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            _vm.Customers.Remove(_vm.SelectedCustomer);
            lvCustomers.SelectedIndex = currentIndex;

        }
        
        private void LeaveApp(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
