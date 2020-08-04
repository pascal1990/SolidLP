using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLP
{
    public class Manager : Employee, IManager
    {
        public void FaireUnRapport()
        {
            Console.WriteLine("Je fais un rapport");
        }

        
        public override decimal CalculSalaire(decimal hours)
        {
            decimal SalaireParHeur = 15.50M;

            Salaire = hours * SalaireParHeur;

            return Salaire;

        }
    }
}
