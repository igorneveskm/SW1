namespace Atividade_03;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Tel {get;set;}
    public int prazo {get;set;}
    public decimal valor {get;set;}

    public decimal Prestacao {get;set;}


    public virtual string Dados(){

        Console.WriteLine("Preencha a ficha a baixo.");
        Console.WriteLine("");
        Console.WriteLine("DADOS PESSOAIS");
        Console.WriteLine("");

        Console.Write("Escreva Seu Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Escreva Seu E-mail: ");
        Email = Console.ReadLine();

        Console.Write("Escreva seu Telefone para contato: ");
        Tel = Console.ReadLine();

        string vazio = ("");
        return vazio;
    }

    public virtual decimal CalcularPrestacao(){

        Console.WriteLine("");
        Console.WriteLine("DADOS PRESTACAO");
        Console.WriteLine("");
        
        Console.Write("Valor: ");
        valor = int.Parse(Console.ReadLine());

        Console.Write("Prazo: ");
        prazo = int.Parse(Console.ReadLine());

       decimal Prestacao = valor/prazo;
       return Prestacao;
    }

}
