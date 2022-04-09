public abstract class Dwarf
{
    public Dwarf(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public abstract void AcceptCalled(Visitor visitor);
    public abstract void AcceptLast(Visitor visitor);
    public abstract void AcceptDisappear(Visitor visitor);
}
