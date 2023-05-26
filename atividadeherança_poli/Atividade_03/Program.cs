namespace Atividade_03;
class Program
{
    static void Main(string[] args)
    {
        Fisico f = new Fisico();
        Juridico j = new Juridico();
    
        Console.WriteLine("Você é uma pessoa fisica ou juridica?");
        string metrica = Console.ReadLine();

       switch (metrica)
        {
            case "fisica":
                Console.WriteLine(f.Dados());
                Console.WriteLine("Valor da parcela: " + f.CalcularPrestacao());
                break;

            case "juridica":
                Console.WriteLine(j.Dados());
                Console.WriteLine("Valor da parcela: " + j.CalcularPrestacao());
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }
}
