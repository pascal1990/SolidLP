using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLP
{
    public interface ISuperviser : IEmployee
    {
        IEmployee Superieur { get; set; }
        void AssignerSuperieur(IEmployee superieur);
    }
}
