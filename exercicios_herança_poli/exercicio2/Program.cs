namespace exercicio2;

class Program
{
    static void Main(string[] args)
    {
       Fisico f = new Fisico();
       Juridico j = new Juridico();
       
       Console.WriteLine("Escolha a opção para contrato: JURIDICO ou FISICO.");
        string metrica = Console.ReadLine();

         switch (metrica)
        {
            case "física":
                Console.WriteLine(f.Dados());
                break;

            case "juridica":
                Console.WriteLine(j.Dados());
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }
}

