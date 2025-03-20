
namespace AulaBasica
{
    public partial class MainPage : TabbedPage
    {
        string nome;
        public MainPage()
        {
            InitializeComponent();
        }
        private async void BTNOla_Clicked(object sender, EventArgs e)
        {
            nome = await DisplayPromptAsync("Nome", "Digite seu nome: ", "Ok");
            await DisplayAlert("Aviso", "Olá " + nome, "Ok");
        }
    }
}
