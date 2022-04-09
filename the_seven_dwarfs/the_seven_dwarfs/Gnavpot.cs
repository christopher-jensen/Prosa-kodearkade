public class Gnavpot : Dwarf
{
    public Gnavpot(string name) : base(name)
    {
    }


    public override void Disappear()
    {
        System.Console.WriteLine("Gnavpot gad ikke mere og forsvandt");
    }
    public override void Last()
    {
        System.Console.WriteLine("Gnavpot blev trist over at være den sidste og lukker festen");
    }
}
