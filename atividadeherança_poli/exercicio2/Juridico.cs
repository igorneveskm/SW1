namespace exercicio2;

class Juridico:Contrato

{   
  public string? CNPJ {get;set;}
    public string? IESTADUAL {get;set;}
    public string? ECONTRATANTE {get;set;}

    public override string Dados(){

        base.Dados();

        Console.WriteLine("");
        Console.WriteLine("DADOS DA EMPRESA");
        Console.WriteLine("");

        Console.Write("CNPJ: ");
        CNPJ = Console.ReadLine();

        Console.Write("IESTADUAL: ");
        IESTADUAL = Console.ReadLine();

        Console.Write("CONTRATANTE: ");
        ECONTRATANTE = Console.ReadLine();
        Console.WriteLine("");

        string vazio = ("OBRIGADO");
        return vazio ;
    }
  
}
