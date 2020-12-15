using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickJokes
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }


        private void AnyJoke(object sender, EventArgs e)
        {
            Anycommand.RelRotateTo(720, 500);
            Anycommand.Text = JokeGenerator.AnyJokeCall();

        }

        private void DadJoke(object sender, EventArgs e)
        {
            Anycommand.RelRotateTo(720, 500);
            Anycommand.Text = JokeGenerator.DadJokeCall();

        }

        private void GeekJoke(object sender, EventArgs e)
        {
            
            Anycommand.RelRotateTo(720, 500);
            Anycommand.Text = JokeGenerator.GeekJokeCall();
        }
    }

}


