namespace DataBinding.Collection.Views;

public partial class MainPage : ContentPage
{
	private List<OrigenDepaquete> _origenes;
	public MainPage()
	{
		OrigenDepaquete? origenSeleccionado = null;
		InitializeComponent();
		_origenes = new List<OrigenDepaquete>();
		CargarDatos();
		OrigenesListView.ItemsSource= _origenes;
		if (_origenes.Count > 0)
		{
			origenSeleccionado = _origenes[0];
		}
        OrigenesListView.ItemsSource = _origenes;
		OrigenesListView.SelectedItem = origenSeleccionado;


    }


	private void CargarDatos()
	{
		_origenes.Add(new OrigenDepaquete
		{
			Nombre = "nuget.org",
			Origen = "https://Api.Nuget.Org/v3/Index.json",
			EstaHabilitado = true,
		});
        _origenes.Add(new OrigenDepaquete
        {
            Nombre = "Microsoft visual studio offline packages",
            Origen = "C:\\Program Files(x86)\\Microsoft sdks\\Nugetpackages",
            EstaHabilitado = false,
        });
		




    }

    private void OnAgregarButtonClicked(object sender, EventArgs e)
    {
        _origenes.Add(new OrigenDepaquete
        {
            Nombre = "Orige del  paquete ",
            Origen = "URL o ruta del origen del paquete",
            EstaHabilitado = false,
        });
		OrigenesListView.ItemsSource = null;
		OrigenesListView.ItemsSource = _origenes;
		OrigenesListView.SelectedItem= _origenes[0];




    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
		
		
		OrigenDepaquete seleccionado =
			  (OrigenDepaquete)OrigenesListView.SelectedItem;

		if (seleccionado == null)
		{
			var indice = _origenes.IndexOf(seleccionado);
			OrigenDepaquete? nuevoseleccionado;
			if (_origenes.Count > 1)
			{
				// hay mas de un elemento
				if (indice < _origenes.Count - 1)
				{
					// el elemento seleccionado no es el ultimo
					nuevoseleccionado = _origenes[indice + 1];
				}
				else
				{
					// el elemento seleccionado es el ultimo
					nuevoseleccionado = _origenes[indice - 1];
				}
			}
			else
			{
				// solo hay un elemento
				nuevoseleccionado = null;
			}
            _origenes.Remove(seleccionado);
            OrigenesListView.ItemsSource = null;
            OrigenesListView.ItemsSource = _origenes;
			OrigenesListView.SelectedItem = nuevoseleccionado;
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
            OrigenesListView.ItemsSource = _origenes;
            OrigenesListView.SelectedItem = origenSelecionado;
        }

    }
}