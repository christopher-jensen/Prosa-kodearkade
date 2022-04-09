using System;
public class Lystig : Dwarf
{
    public Lystig(string name) : base(name)
    {
    }
    public override void CallBrille()
    {
        Console.WriteLine("Lystig kaldte på Brille, som har travlt med at lede efter sin agenda");
    }

    public override void CallDumpe()
    {
        Console.WriteLine("Lystig tog fat i dumpe, fordi de har travlt");
    }

    public override void CallFlovmand()
    {
        Console.WriteLine("Lystig overraskede Flovmand, som gemmer sig i skægget");
    }

    public override void CallGnavpot()
    {
        Console.WriteLine("Lystig prøver at få Gnavpotshumør op");
    }

    public override void CallLystig()
    {
        throw new System.NotImplementedException();
    }

    public override void CallProsit()
    {
        throw new System.NotImplementedException();
    }

    public override void CallSøvnig()
    {
        throw new System.NotImplementedException();
    }

    public override void Disappear()
    {
        Console.WriteLine("Lystig blev ked og smuttede");
    }

    public override void Last()
    {
        Console.WriteLine("Lystig smuttede, da der ikke var flere til fest");
    }
}