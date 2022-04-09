public class Flovmand : Dwarf
{
    public Flovmand(string name) : base(name)
    {
    }


    public override void Disappear()
    {
        System.Console.WriteLine("Flovmand blev for flov og gravlede tilbage til sit hus");
    }
    public override void Last()
    {
        System.Console.WriteLine("Flovmand blev for flov og lukkede festen");
    }
}