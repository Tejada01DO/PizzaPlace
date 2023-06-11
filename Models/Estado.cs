namespace ProyectoPizza.Shared
{
    public class Estado
    {
        public PizzaBLL pizzaBLL { get; } = new PizzaBLL();
        public Compra compra { get; } = new Compra();
        public Usuario usuario { get; set; } = new Usuario();
    }
}