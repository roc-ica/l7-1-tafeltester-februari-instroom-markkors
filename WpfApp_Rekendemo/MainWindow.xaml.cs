using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfApp_Rekendemo.Classes;

namespace WpfApp_Rekendemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            InitEvents();
            Debug.WriteLine(App.intGlobal);
        }
        #endregion
        
        private void InitEvents()
        {
            btnDoSomething.Click += BtnDoSomething_Click;
            btnDoSomethingElse.Click += BtnDoSomethingElse_Click;
            txtInputSomething.KeyDown += TxtInputSomething_KeyDown;
            txtInputSomething.TextChanged += TxtInputSomething_TextChanged;
            
            App.strGlobal = "Dit is een test";


            oSom newsom = new oSom();
           

            MessageBox.Show(newsom.getal1.ToString());
            MessageBox.Show(newsom.getal2.ToString());
        }





        #region EventHandlers

        private void TxtInputSomething_TextChanged(object sender, TextChangedEventArgs e)
        {
            App.strInputText = txtInputSomething.Text;
        }

        private void TxtInputSomething_KeyDown(object sender, KeyEventArgs e)
        {
            //string strTyped = e.Key.ToString();
            //MessageBox.Show(strTyped);
            
        }
        private void BtnDoSomethingElse_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("En dit is wat anders");
            
            
            frmSecondWindow fsw1 = new frmSecondWindow();
            fsw1.Show();

           
        }

        private void BtnDoSomething_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welkom bij de app.....");
            txtInputSomething.Text = "Dit is een test";

        }

        #endregion

    
    }
}
