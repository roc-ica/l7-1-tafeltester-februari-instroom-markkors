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
using System.Windows.Shapes;

namespace WpfApp_Rekendemo
{
    /// <summary>
    /// Interaction logic for MyNewWindow.xaml
    /// </summary>
    public partial class MyNewWindow : Window
    {
        public MyNewWindow()
        {
            InitializeComponent();
            btnCalculate.Click += BtnCalculate_Click;
            tb1.KeyDown += Tb1_KeyDown;
            tb2.KeyDown += Tb2_KeyDown;


        }

        private void Tb2_KeyDown(object sender, KeyEventArgs e)
        {
            // prevent the user from entering non-numeric characters
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                e.Handled = true;
            }
        }

        private void Tb1_KeyDown(object sender, KeyEventArgs e)
        {
            // prevent the user from entering non-numeric characters
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                e.Handled = true;
            }
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                float v1 = float.Parse(tb1.Text);
                float v2 = float.Parse(tb2.Text);
                float r = v1 / v2;
                lblResult.Content = r;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
