namespace ExerciciosAlunos;
class Alunos
{
    public string nome="";

    public double nota1, nota2;
    //MEDIA = RETORNA UM DOUBLE (POR EXEMPLO UM NUMERO COMO 8.3)
    public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;

    }

    //SITUAÇÃO = RETORNA UMA STRING ("APROVADO" OU "REPROVADO")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
        situacao="Aprovado";
         }else{
            situacao="Reprovado";
         } 
         return situacao;
    }

    //MENSAGEM =

    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao =  obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" esta "+resultadoSituacao+" com média: "+mediaCalculada);
         }
    }



