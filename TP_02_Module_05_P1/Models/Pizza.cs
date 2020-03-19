using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02_Module_05_P1.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Pate Pate { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public Pizza (int id, String nom, Pate pate, List<Ingredient> ingredients)
        {
            this.Id = id;
            this.Nom = nom;
            this.Pate = pate;
            this.Ingredients = ingredients;
        }
    }
}
