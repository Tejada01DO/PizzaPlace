using System.Collections.Generic;
using System.Linq;

namespace ProyectoPizza.Shared
{
    public class PizzaBLL
    {
        public List<Pizza> pizzas { get; set; } = new List<Pizza>();

        public void Agregar(Pizza pizza) => pizzas.Add(pizza);

        public Pizza? ObtenerPizza(int pizzaId) => pizzas.SingleOrDefault(pizza => pizza.PizzaId == pizzaId); 
    }
}