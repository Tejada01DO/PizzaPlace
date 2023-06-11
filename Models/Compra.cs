using System.Collections.Generic;

namespace ProyectoPizza.Shared
{
    public class Compra
    {
        public Cliente cliente { get; set; } = new Cliente();
        public List<int> Pedidos { get; set; } = new List<int>();
        public bool Pagado { get; set; }

        public void Agregar(int PizzaId)
        {
            Pedidos.Add(PizzaId);
        }
    }
}