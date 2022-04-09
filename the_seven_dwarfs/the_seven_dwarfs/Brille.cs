public class Brille : Dwarf
{
    public Brille(string name) : base(name)
    {
    }

   
    public override void Disappear()
    {
        System.Console.WriteLine("Brille kan ikke finde sinde briller og er smuttet ud i busken efter dem");
    }
    public override void Last()
    {
        System.Console.WriteLine("Brille fandt sine briller, men opdagede at folk var væk. Han smutter som den sidste");
    }
}
