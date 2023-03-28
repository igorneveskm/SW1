namespace projeto_pessoa;
class Pessoa
{
    public Pessoa(){
        this.Nome = "NÃO INFORMADO";
        this.SobreNome = "NÃO INFORMADO";
        this.Idade = 0;
    }
    public Pessoa(string nome,int idade){
        this.Nome = nome;
        this.SobreNome = "NÃO INFORMADO";
        this.Idade = idade;
    }
    private string? Nome {get;set;}
     private string? SobreNome {get;set;}
      private int? Idade {get;set;}



      public void AlterarNome(string nome){
        this.Nome = nome;
      }
      public void AlterarSobreNome(string sobrenome){
        this.SobreNome = sobrenome;
}
public void AlterarIdade(int idade){
        this.Idade = idade;
}
public void MostraDados(){
    Console.WriteLine("Nome:"+this.Nome);
    Console.WriteLine("SobreNome:"+this.SobreNome);
    Console.WriteLine("Idade:"+this.Idade);
}
}