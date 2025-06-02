namespace CarvajalDExamen
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Chistes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Chistes());
        }
        private async void SobreMi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.SobreMi());
        }

    }
}
