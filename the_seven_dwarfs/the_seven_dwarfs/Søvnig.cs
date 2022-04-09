public class Søvnig : Dwarf
{
    public Søvnig(string name) : base(name)
    {
    }


    public override void Disappear()
    {
        System.Console.WriteLine("Søvnig blev træt og gik i seng");
    }
    public override void Last()
    {
        System.Console.WriteLine("Søvnig er for første gang den sidste oppe, men hopper i seng nu");
    }
}