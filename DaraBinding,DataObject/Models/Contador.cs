using System.ComponentModel;

namespace DaraBinding_DataObject.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int _conteo;
        public event PropertyChangedEventHandler? PropertyChanging;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }

        }
        public Contador()
        {
            Conteo = 0;
        }

        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public void Contar()
        {
            Conteo++;
        }
        public void Reiniciar()
        {
            Conteo = 0;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChangedEventHandler != null)
            {
                PropertyChangedEventHandler(
                    this, new PropertyChangedEventArgs(propertyName));
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
