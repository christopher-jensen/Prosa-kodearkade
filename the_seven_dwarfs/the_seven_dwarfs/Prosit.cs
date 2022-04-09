public class Prosit : Dwarf
{
    public Prosit(string name) : base(name)
    {
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitProsit(this);
    }
}