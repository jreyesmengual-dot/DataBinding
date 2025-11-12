namespace DataBinding.Collection
{
    public class OrigenDepaquete
    {
        public string Nombre { get; set; } 
        public string Origen { get; set; } 
        public bool EstaHabilitado { get; set; } = false;

        public override string ToString()
        {
            return $"{Nombre} - ({Origen})";
        }
    }
   
}
