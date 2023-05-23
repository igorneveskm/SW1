namespace herança_polimorfismo;

class Homem:Animal
{
    public override string Fala(){
        return base.Fala() + "oi oi";
    }
}