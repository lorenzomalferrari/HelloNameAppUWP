using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWordApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            inizializzazione();
        }

        private void inizializzazione()
        {
            tblockNome.Text = "Inserisci il nome:";
            tboxNome.Text = "";
            btInvia.Content = "Invia";
            this.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
        }

        private void btInvia_Click(object sender, RoutedEventArgs e)
        {
            //if (tblockNome.Text == "")
            //{
                tblockMessaggio.Text = "Hello " + tboxNome.Text;
            //}
        }
    }
}
