namespace ProyectoPizza.Shared
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string? Nombre { get; set; } = default!;
        public string? Calle { get; set; } = default!;
        public string? Ciudad { get; set; } = default!;
    }
}