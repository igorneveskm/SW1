namespace herança_polimorfismo;

class Program
{
    static void Main(string[] args)
    {
       Gato gato = new Gato(); 
       Cao  cao = new Cao();
       Homem homem = new Homem();
       
       Console.WriteLine("O gato " + gato.Fala());
       Console.WriteLine("O cao " + cao.Fala());
       Console.WriteLine("o homem " + homem.Fala());
    }
}
