namespace ExerciciosAlunos;
class Program
{
    static void Main(string[] args)
    {
      
        Alunos aluno1 = new Alunos();
        Console.WriteLine("Digite seu nome ");
        aluno1.nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: " + aluno1.nome);
        Console.WriteLine("");


        Console.WriteLine("Digite uma nota double: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("O número digitado é: " + aluno1.nota1);

       
        Console.WriteLine("Digite a 2 Nota double: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());
       Console.WriteLine("O 2 número digitado é: " + aluno1.nota2);

       aluno1.mensagem();

    }
}
