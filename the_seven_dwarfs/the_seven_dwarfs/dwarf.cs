public abstract class Dwarf
{
    public Dwarf(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    public abstract void Disappear();
    public abstract void Last();

    public abstract void CallBrille();
    public abstract void CallGnavpot();
    public abstract void CallLystig();
    public abstract void CallProsit();
    public abstract void CallFlovmand();
    public abstract void CallSøvnig();
    public abstract void CallDumpe();

}
