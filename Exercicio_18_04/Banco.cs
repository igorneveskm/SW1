namespace Exercicio_18_04;
class Banco
{   
    //Funções originais do banco

    public int Numero {get; set;}
    private double Saldo { get;  set;}
    public double Limite {get; private set;}

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }
    public void Depositar( double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if (this.Saldo + this.Limite <= valor){
            Console.WriteLine("Você está sacando mais do que possui");
        }else{
             this.Saldo -= valor;
        }
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }

    //Nova função de empréstimo

    public double parcela {get; set;}
    public double valor {get; set;}

    public string emprestimo(int parcelas, double dinheiro){
        this.parcela = parcelas;
        this.valor = dinheiro;
        
        double divi = dinheiro/parcelas;
        double multi = dinheiro * 0.06;
        double soma = multi + divi;
        double total = soma * parcelas;

        string resultado = "O valor da sua parcela sem juros é: "+ divi +". O valor da parcela com juros: "+ multi + ". O valor do juros com prestações é de: "+ soma +"e o valor total a pagar é de: "+total;
        return resultado;
        
     
    }
    public void imprimi(string texto){
        Console.WriteLine(texto);
    }
}
