
namespace _4M_05_KolkoIKrzyzyk
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private bool kolko = true;
        private void btn00Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn00.Source = napis;
            btn00.IsEnabled = false;
            kolko = !kolko;
        }
        private void btn01Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn01.Source = napis;
            btn01.IsEnabled = false;
            kolko = !kolko;
        }
        private void btn02Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn02.Source = napis;
            btn02.IsEnabled = false;
            kolko = !kolko;
        }

        private void btn10Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn10.Source = napis;
            btn10.IsEnabled = false;
            kolko = !kolko;
        }
        private void btn11Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn11.Source = napis;
            btn11.IsEnabled = false;
            kolko = !kolko;
        }
        private void btn12Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn12.Source = napis;
            btn12.IsEnabled = false;
            kolko = !kolko;
        }

        private void btn20Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn20.Source = napis;
            btn20.IsEnabled = false;
            kolko = !kolko;
        }
        private void btn21Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn21.Source = napis;
            btn21.IsEnabled = false;
            kolko = !kolko;
        }
        private void btn22Clicked(object sender, EventArgs e)
        {
            string napis = kolko ? "kolko.png" : "krzyzyk.png";
            btn22.Source = napis;
            btn22.IsEnabled = false;
            kolko = !kolko;
        }

    }
}