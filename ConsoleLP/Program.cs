using System;

namespace ConsoleLP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Manager manager = new Manager();
            manager.Prenom = "Pascal";
            manager.Nom = "Fossouo";
            manager.CalculSalaire(40);
            
            Employee emp = new Manager();
            emp.Prenom = "Pascal";
            emp.Nom = "Fossouo";            
            emp.AssignerSuperieur(manager);
            emp.CalculSalaire(40);
            
            Console.WriteLine($"{emp.Prenom} {emp.Nom} son salaire {emp.Salaire}");
            Console.ReadKey();
            
        }
    }
}
