using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP_02_Module_05_P1.Utils;

namespace TP_02_Module_05_P1.Models
{
    public class ViewModel
    {
        public string Nom { get; set; }
        public List<Pate> Pate { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public ViewModel()
        {
            this.Pate = FakeDbCat.Instance.Pates;
            this.Ingredients = FakeDbCat.Instance.Ingredients;
        }
    }
}