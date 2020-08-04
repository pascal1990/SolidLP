using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLP
{
    public abstract class BaseEmployee : IEmployee
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public decimal Salaire { get; set; }


        public virtual decimal CalculSalaire(decimal hours)
        {
            decimal SalaireParHeur = 12.50M;
            Salaire = hours * SalaireParHeur;

            return Salaire;

        }
    }
}
