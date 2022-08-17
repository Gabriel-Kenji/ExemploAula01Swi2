using ExemploAula01.Negocio;
using ExemploAula01.Repositorio;

class Program
{
    static void Main(string[] args)
    {
        var _repo = new LivroRepositorioCSV();
        ImprimeLista(_repo.ParaLer);
        ImprimeLista(_repo.Lendo);
        ImprimeLista(_repo.Lidos);
    }

    static void ImprimeLista(ListaDeLeitura lista)
    {
        Console.WriteLine(lista);
    }
}