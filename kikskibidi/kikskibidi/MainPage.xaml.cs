using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kikskibidi
{
    public partial class MainPage : ContentPage
    {
        private bool turn = true;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Restart(object sender, EventArgs e)
        {

        }

        private void DisplayWin()
        {
            if (turn)
                DisplayAlert("Koniec gry!", "Wygrywa x!", "ciezko pracuje");
            else
                DisplayAlert("Koniec gry!", "Wygrywa x!", "ciezko pracuje");

        }
    }
}
