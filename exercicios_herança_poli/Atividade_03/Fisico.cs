namespace Atividade_03;
class Fisico: Contrato
{
    public string? cpf {get;set;}
    public int idade {get;set;}

    public override string Dados(){

        base.Dados();

        Console.Write("CPF: ");
        cpf = Console.ReadLine();

        Console.Write("IDADE: ");
        idade = int.Parse(Console.ReadLine());;
        Console.Write("");

        string vazio = ("OBRIGADO");
        return vazio;
    }

public override decimal CalcularPrestacao(){

        if(idade <= 30){
            return (base.CalcularPrestacao()+1);
        }else 
        
        if(idade <=40){
            return (base.CalcularPrestacao()+2);
        }else 
        
        if(idade <=50){
            return (base.CalcularPrestacao()+3);
        }
        
        else{
            return (base.CalcularPrestacao()+4);
        }
    }
    

}
