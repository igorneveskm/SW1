namespace exercicio2;

class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Telefone {get;set;}

    public virtual string Dados(){
         
         Console.WriteLine("Preencha a ficha abaixo:");
         Console.WriteLine("");
         Console.WriteLine("Dados Pessoais");
         Console.WriteLine("");

         Console.Write("Escreva seu nome:");
         Nome = Console.ReadLine();

         Console.Write("Escreva seu email:");
         Email = Console.ReadLine();

         Console.Write("Telefone para contato");
         Telefone = Console.ReadLine();

         string vazio = ("");
         return vazio;

    }
   
}
