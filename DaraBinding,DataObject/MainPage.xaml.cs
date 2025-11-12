using DaraBinding_DataObject.Models;

namespace DaraBinding_DataObject
{
    public partial class MainPage : ContentPage
    {

        // _conteo lleva el conteo de la aplicacion
        private Contador contador;

        public MainPage()
        {
            InitializeComponent();
            contador = new Contador ();
            BindingContext = contador;
            //ConteoLabel.Text = Contador.Conteo.ToString();
        }
        private void OnReniniciarButtonClicked(object sender, EventArgs e)
        {
           contador.Reiniciar();
            //ConteoLabel.Text = contador .Conteo.ToString();

        }

        private void OnContarButtonClicked(object sender, EventArgs e)
        {
            contador.Contar();
            //ConteoLabel.Text = contador.Conteo.ToString();
        }


    }
}
