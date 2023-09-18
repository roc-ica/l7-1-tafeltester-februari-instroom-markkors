using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp_Rekendemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {

        public static string strGlobal;
        public static int intGlobal = 0;
        public static string strInputText;

        #region Constructor
        public App()
        {
            intGlobal = 10;
        }

        #endregion
    }
}
