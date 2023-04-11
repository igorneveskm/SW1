namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com agregação");
        
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();
        
        cli.Nome = "Igor";

        cdc.Numero = "123654789";
        cdc.DataValidade = "01/2027";

         cdc.Cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);
    }
}
