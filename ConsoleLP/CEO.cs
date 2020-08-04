using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLP
{
    public class CEO : BaseEmployee, IManager
    {
        public void FaireUnRapport()
        {
            Console.WriteLine("Je fais un rapport");
        }


        public override decimal CalculSalaire(decimal hours)
        {
            decimal SalaireParHeur = 20.50M;

            Salaire = hours * SalaireParHeur;

            return Salaire;

        }
        public void RapportAnnuel()
        {
            Console.WriteLine("Faire le Rapport Annuel");
        }
    }
}
