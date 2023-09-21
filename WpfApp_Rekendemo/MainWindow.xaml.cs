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

        List<oSom> Sommen = new List<oSom>();
        


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


            // create more soms:
            Random MyRandomizer = new Random();
            for (int i=0;i<10;i++)
            {
                oSom newsom = new oSom(MyRandomizer);
                Sommen.Add(newsom);
            }

            dCombo.DisplayMemberPath = "Operator";
            dCombo.ItemsSource = Sommen;
            
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
