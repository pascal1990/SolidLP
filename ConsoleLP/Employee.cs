using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLP
{
    public class Employee : BaseEmployee, ISuperviser
    {
        public IEmployee Superieur { get; set; } = null;

        public void AssignerSuperieur(IEmployee superieur)
        {
            Superieur = superieur;
        }
    }
}
