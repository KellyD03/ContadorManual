using ContadorManual.Gui.Models;

namespace ContadorManual.Gui
{
    public partial class MainPage : ContentPage
    {
        //_conteo lleva el conteo de la aplicacion
        private Contador contador;

        public MainPage()
        {
            InitializeComponent();
            contador = new Contador();
            ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void OnReiniciarButton_Clicked(object sender, EventArgs e)
        {
            contador.Reiniciar();
            ConteoLabel.Text = contador.Conteo .ToString();
        }

        private void OnContarButton_Clicked(object sender, EventArgs e)
        {
            contador.Contar();
            ConteoLabel.Text = contador.Conteo.ToString();
        }
    }
}
