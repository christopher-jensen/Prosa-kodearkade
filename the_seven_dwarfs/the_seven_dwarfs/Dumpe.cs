public class Dumpe : Dwarf
{
    public Dumpe(string name) : base(name)
    {
    }


    public override void Disappear()
    {
        System.Console.WriteLine("Dumpe skvattede og faldt ned i et hul");
    }
    public override void Last()
    {
        System.Console.WriteLine("Dumpe snublede og brændte byen ned. Øvbøv");
    }
}