namespace herança_polimorfismo;

class Gato:Animal
{
    public override string Fala(){
        return base.Fala() + "miau";
    }
}