namespace ProyectoPizza.Shared
{
    public class Pizza
    {

        public int PizzaId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Picante picantes { get; set; }
        public Pizza(int PizzaId, string Nombre, decimal precio, Picante picantes)
        {
            this.PizzaId = PizzaId;
            this.Nombre = Nombre;
            this.Precio = precio;
            this.picantes = picantes;
        }
    }
}