namespace ConsoleLP
{
    public interface IEmployee
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        decimal Salaire { get; set; }

        decimal CalculSalaire(decimal hours);
    }
}