using DataBinding.Collection.Models;
using System.Collections.ObjectModel;


namespace DataBinding.Collection.Views;

public partial class MainPage : ContentPage
{
	public ObservableCollection<OrigenDepaquete> Origenes { get; }
	private OrigenDepaquete? _origenSeleccionado = null;
	private string _nombreDelOrigen = string.Empty;
	private string _rutaDelOrigen = string.Empty;

	public OrigenDepaquete OrigenSeleccionado
	{
		get => _origenSeleccionado;
		set
		{
			if (_origenSeleccionado != value)
			{
				_origenSeleccionado = value;
				OnPropertyChanged(nameof(OrigenSeleccionado));
			}
		}
	}
	public string Nombredelorigen
	{
		get => _nombreDelOrigen;
		set
		{
			if (_nombreDelOrigen != value) ;
			OnPropertyChanged(nameof(_nombreDelOrigen));

		}
	}

	public string RutadelOrigen
	{
		get => _rutaDelOrigen;
		set
		{
			if (_rutaDelOrigen != value)
				OnPropertyChanged(nameof(RutadelOrigen));
		}

	}


	public MainPage()
	{

		InitializeComponent();

		OrigenSeleccionado = null;
		Origenes = new ObservableCollection<OrigenDepaquete>();
		CargarDatos();
		BindingContext = this;
		OrigenesListView.ItemsSource = Origenes;
		if (Origenes.Count > 0)
		{
			OrigenSeleccionado = Origenes[0];
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
			Nombre = "Origen del  paquete ",
			Origen = "URL o ruta del origen del paquete",
			EstaHabilitado = false,
		};
		Origenes.Add(origen);
		OrigenSeleccionado = origen;

	}

	private void OnDeleteButtonClicked(object sender, EventArgs e)
	{


		if (OrigenSeleccionado != null)
		{
			var indice = Origenes.IndexOf(OrigenSeleccionado);
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
			Origenes.Remove(OrigenSeleccionado);
			OrigenSeleccionado = nuevoseleccionado;
		}


	}

	private void OrigenesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (OrigenSeleccionado != null)
		{
			Nombredelorigen = OrigenSeleccionado.Nombre
			= OrigenSeleccionado.Origen;
		}
		else
		{
			Nombredelorigen = string.Empty;
			RutadelOrigen = string.Empty;
		}

	}

	private void OnActualizarButtonClicked(object sender, EventArgs e)
	{

		if (OrigenSeleccionado != null)
		{
			OrigenSeleccionado.Nombre = NombreEntry.Text;
			OrigenSeleccionado.Origen = OrigenEntry.Text;


		}
	}
}