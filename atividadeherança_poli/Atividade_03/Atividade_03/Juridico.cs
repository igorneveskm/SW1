namespace Atividade_03;
class Juridico: Contrato
{
    public string? cnpj {get;set;}
    public int IESTADUAL {get;set;}
    public string? ECONTRATANTE {get;set;}

    public override string Dados(){

        base.Dados();

        Console.WriteLine("");
        Console.WriteLine("DADOS DA EMPRESA");
        Console.WriteLine("");

        Console.Write("CNPJ: ");
        cnpj = Console.ReadLine();

        Console.Write("IESTADUAL: ");
        int IESTADUAL = int.Parse(Console.ReadLine());

        Console.Write("ECONTRATANTE: ");
        ECONTRATANTE = Console.ReadLine();
        Console.WriteLine("");

        string vazio = ("OBRIGADO");
        return vazio ;
        
    }

    public override decimal CalcularPrestacao()
    {
        return base.CalcularPrestacao()+3;
    }

}
