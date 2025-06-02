namespace CarvajalDExamen.Views;
using Newtonsoft.Json;


public partial class Chistes : ContentPage
{
    public Chistes()
    {
        InitializeComponent();
        CargarChiste();
    }

    private async void CargarChiste()
    {
        try
        {
            using var client = new HttpClient();
            var response = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
            var chistesf = JsonConvert.DeserializeObject<Chiste>(response);
            ChisteLabel.Text = $"{chistesf.Setup}\n\n{chistesf.Punchline}";
        }
        catch
        {
            ChisteLabel.Text = "Error al obtener el chiste.";
        }
    }

    private void OtroChiste(object sender, EventArgs e)
    {
        CargarChiste();
    }

    public class Chiste
    {
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}