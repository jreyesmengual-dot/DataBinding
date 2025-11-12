using DataBinding.Collection.Models;
using System.Collections.ObjectModel;


namespace DataBinding.Collection.Views;

public partial class MainPage : ContentPage
{
	private ObservableCollection<OrigenDepaquete> Origenes { get; }
	public MainPage()
	{
		
		InitializeComponent();
		OrigenDepaquete? origenSeleccionado = null;
		Origenes = new ObservableCollection<OrigenDepaquete>();
		CargarDatos();
		OrigenesListView.ItemsSource= Origenes;
		if (Origenes.Count > 0)
		{
			origenSeleccionado = Origenes[0];
		}
        //OrigenesListView.ItemsSource = Origenes;
		//OrigenesListView.SelectedItem = origenSeleccionado;


    }


	private void CargarDatos()
	{
		Origenes.Add(new OrigenDepaquete
		{
			Nombre = "nuget.org",
			Origen = "https://Api.Nuget.Org/v3/Index.json",
			EstaHabilitado = true,
		});
        Origenes.Add(new OrigenDepaquete
        {
            Nombre = "Microsoft visual studio offline packages",
            Origen = "C:\\Program Files(x86)\\Microsoft sdks\\Nugetpackages",
            EstaHabilitado = false,
        });
		




    }

    private void OnAgregarButtonClicked(object sender, EventArgs e)
    {
        var origen = new OrigenDepaquete 
        {
            Nombre = "Orige del  paquete ",
            Origen = "URL o ruta del origen del paquete",
            EstaHabilitado = false,
        };
		Origenes.Add(origen);
		
		//OrigenesListView.ItemsSource = null;
		//OrigenesListView.ItemsSource = _origenes;
		//OrigenesListView.SelectedItem= origen;




    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
		//OrigenDepaquete seleccionado =
		//	  (OrigenDepaquete)OrigenesListView.SelectedItem;

		OrigenDepaquete seleccionado = null;
		if (seleccionado == null)
		{
			var indice = Origenes.IndexOf(seleccionado);
			OrigenDepaquete? nuevoseleccionado;
			if (Origenes.Count > 1)
			{
				// hay mas de un elemento
				if (indice < Origenes.Count - 1)
				{
					// el elemento seleccionado no es el ultimo
					nuevoseleccionado = Origenes[indice + 1];
				}
				else
				{
					// el elemento seleccionado es el ultimo
					nuevoseleccionado = Origenes[indice - 1];
				}
			}
			else
			{
				// solo hay un elemento
				nuevoseleccionado = null;
			}
			//Origenes.Remove(seleccionado);
			//OrigenesListView.ItemsSource = null;
			//OrigenesListView.ItemsSource = Origenes;
			//OrigenesListView.SelectedItem = nuevoseleccionado;
		}
		

    }

    private void OrigenesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		OrigenDepaquete origenSelecionado= 
			(OrigenDepaquete)OrigenesListView.SelectedItem as OrigenDepaquete;
		if (origenSelecionado != null)
		{
            NombreEntry.Text = origenSelecionado.Nombre;
            OrigenEntry.Text = origenSelecionado.Origen;
        }
		else
		{
            NombreEntry.Text = string.Empty;
            OrigenEntry.Text = string.Empty;
        }
		
    }

    private void OnActualizarButtonClicked(object sender, EventArgs e)
    {
		OrigenDepaquete? origenSelecionado =
			OrigenesListView.SelectedItem as OrigenDepaquete;
		if (origenSelecionado != null)
		{
			origenSelecionado.Nombre = NombreEntry.Text;
			origenSelecionado.Origen = OrigenEntry.Text;
            OrigenesListView.ItemsSource = null;
            OrigenesListView.ItemsSource = Origenes;
            OrigenesListView.SelectedItem = origenSelecionado;
        }

    }
}