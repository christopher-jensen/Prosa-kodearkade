using System;
using System.Collections.Generic;

namespace the_seven_dwarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller ctr = new Controller();
            List<Dwarf> dwarfs = ctr.CreateDwarfsList();

        }
    }
}