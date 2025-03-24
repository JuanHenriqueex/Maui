
namespace AulaBasica
{
    public partial class MainPage : TabbedPage
    {
        string nome;
        public MainPage()
        {
            InitializeComponent();

            string endereco = "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/x9jmkLaIiiE?si=cc7Hfxh4hw-M0fWn\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" referrerpolicy=\"strict-origin-when-cross-origin\" allowfullscreen></iframe>";
            WVVideo.Source = new HtmlWebViewSource
            {
                Html = endereco
            };
        }
        private async void BTNOla_Clicked(object sender, EventArgs e)
        {
            nome = await DisplayPromptAsync("Nome", "Digite seu nome: ", "Ok");
            await DisplayAlert("Aviso", "Olá " + nome, "Ok");
        }
    }
}
