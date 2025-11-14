using DataBinding.Collection.Models;
using System.Collections.ObjectModel;


namespace DataBinding.Collection.Views;

public partial class MainPage : ContentPage
{
<<<<<<< HEAD
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
=======
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
>>>>>>> 9981e94724039b7cd24707fc2d8e1dfafc199c06
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
<<<<<<< HEAD
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
=======
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
>>>>>>> 9981e94724039b7cd24707fc2d8e1dfafc199c06
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
<<<<<<< HEAD
			Origenes.Remove(OrigenSeleccionado);
			OrigenSeleccionado = nuevoseleccionado;
		}
=======
		}
		
>>>>>>> 9981e94724039b7cd24707fc2d8e1dfafc199c06


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
<<<<<<< HEAD
			OrigenSeleccionado.Nombre = NombreEntry.Text;
			OrigenSeleccionado.Origen = OrigenEntry.Text;
=======
			origenSelecionado.Nombre = NombreEntry.Text;
			origenSelecionado.Origen = OrigenEntry.Text;
            OrigenesListView.ItemsSource = null;
            OrigenesListView.ItemsSource = Origenes;
            OrigenesListView.SelectedItem = origenSelecionado;
        }
>>>>>>> 9981e94724039b7cd24707fc2d8e1dfafc199c06


		}
	}
}