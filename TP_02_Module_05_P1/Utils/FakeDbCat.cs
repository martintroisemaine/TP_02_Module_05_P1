using TP_02_Module_05_P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_02_Module_05_P1.Utils
{
    public class FakeDbCat
    {
        private static FakeDbCat _instance;
        static readonly object instanceLock = new object();

        private FakeDbCat()
        {
            pates = this.PatesDisponibles();
            ingredients = this.IngredientsDisponibles();
            pizzas = this.PizzasDisponibles();
        }

        public static FakeDbCat Instance
        {
            get
            {
                if (_instance == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
                {
                    lock (instanceLock)
                    {
                        if (_instance == null) //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                            _instance = new FakeDbCat();
                    }
                }
                return _instance;
            }
        }

        private List<Pizza> pizzas;

        public List<Pizza> Pizzas
        {
            get { return pizzas; }
        }

        private List<Pizza> PizzasDisponibles()
        {
            var i = 1;
            return new List<Pizza>
            {

            };
        }

        private List<Ingredient> ingredients;

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
        }

        private List<Ingredient> IngredientsDisponibles()
        {
            var i = 1;
            return new List<Ingredient>
            {
                new Ingredient{Id=i++,Nom="Mozzarella"},
                new Ingredient{Id=i++,Nom="Jambon"},
                new Ingredient{Id=i++,Nom="Tomate"},
                new Ingredient{Id=i++,Nom="Oignon"},
                new Ingredient{Id=i++,Nom="Cheddar"},
                new Ingredient{Id=i++,Nom="Saumon"},
                new Ingredient{Id=i++,Nom="Champignon"},
                new Ingredient{Id=i++,Nom="Poulet"}
            };
        }

        private List<Pate> pates;

        public List<Pate> Pates
        {
            get { return pates; }
        }

        private List<Pate> PatesDisponibles()
        {
            var i = 1;
            return new List<Pate>
            {
                new Pate{ Id=i++,Nom="Pate fine, base crême"},
                new Pate{ Id=i++,Nom="Pate fine, base tomate"},
                new Pate{ Id=i++,Nom="Pate épaisse, base crême"},
                new Pate{ Id=i++,Nom="Pate épaisse, base tomate"}
            };
        }
    }
}