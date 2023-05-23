namespace herança_polimorfismo;

class Cao:Animal
{
    public override string Fala(){
        return base.Fala() + "au au";
    }
}
