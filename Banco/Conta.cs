namespace Aula18_04_23;
class Conta{

public double Valor;
    public double Saldo{get;set;}
    public double Limite{get;set;}
    
    public double obterjuros(){
        double Juros = ((Valor * 0.06)*12) + Valor;
        return Juros;
    }

    public double Mensal(){
        double Mes = (Valor * 0.06 + Valor/12);
        return Mes;
    }

    public void Depositar(double custo){
        this.Saldo += Valor;
    }

    public void Sacar(double custo){
        this.Saldo -= Valor;
    }

    public double ConsutSaldo(){
        return this.Saldo += this.Limite;
    }

}
