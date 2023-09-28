using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
             
        public event PropertyChangedEventHandler PropertyChanged;

       

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            InitEvents();
            // om bindings met het XAML form te realiseren moet de DataContext van het form
            // worden ingesteld op "this"
            this.DataContext = this;

            double[] c;

            Debug.WriteLine("Dit is een test");

        }
        #endregion
        
        private void InitEvents()
        {
            btnDoSomething.Click += BtnDoSomething_Click;
            btnDoSomethingElse.Click += BtnDoSomethingElse_Click;
            txtInputSomething.KeyDown += TxtInputSomething_KeyDown;
            txtInputSomething.TextChanged += TxtInputSomething_TextChanged;
            lstSommen.SelectionChanged += LstSommen_SelectionChanged;

            App.strGlobal = "Dit is een test";

            // create more soms:
            Random MyRandomizer = new Random();
            List<oSom> coll = new List<oSom>();
            for (int i=0;i<10;i++)
            {
                oSom newsom = new oSom(MyRandomizer,oSom.eDifficulty.hard);
                coll.Add(newsom);
            }

            Sommen = coll;
            // trigger the propertychanged event (voor de bindings)
            OnPropertyChanged("Sommen");

        }

        private void LstSommen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // get selected item from listbox
            //
            //
            ListBox lb = (ListBox)sender;
            oSom s = (oSom)lb.SelectedItem;
            
            
           //oSom selectedSom = (oSom)lstSommen.SelectedItem;
           //MessageBox.Show(selectedSom.SumAsTextWithResult);

        }



        #region "properties"
        public List<oSom> Sommen { get; set; }

        #endregion

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


            MyNewWindow mnw1 = new MyNewWindow();
            mnw1.Show();



           
        }

        private void BtnDoSomething_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welkom bij de app.....");
            txtInputSomething.Text = "Dit is een test";

        }


        #endregion

        
    }
}
