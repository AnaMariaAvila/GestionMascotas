namespace GestionMascotas.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Raza { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public bool Vacunado { get; set; }
    }
}