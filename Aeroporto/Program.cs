namespace Aeroporto;
class Program
{
    static void Main(string[] args)
    {
        Aeroporto a1 = new Aeroporto();
        a1.AlteraCodigo(1);
        a1.AlteraNome("Gol");
        a1.MostraDados();

    }
}
