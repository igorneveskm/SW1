namespace exercicio2;

class Fisico:Contrato

{
    public string? cpf {get;set;} 
    public string? idade {get;set;}

    public override string Dados(){

        base.Dados();

        Console.Write("Escreva seu Cpf: ");
        cpf = Console.ReadLine();

        Console.Write("Escreva sua Idade: ");
        idade = Console.ReadLine();

        string vazio = ("OBRIGADO");
        return vazio ;
        
    }


}
