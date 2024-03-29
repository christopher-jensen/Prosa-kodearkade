﻿using System;
using System.Collections.Generic;

namespace the_seven_dwarfs
{
    public class Controller
    {
        const int total_dwarfs = 7;
        private Random rnd = new Random();
        List<Dwarf> all_dwarfs = new List<Dwarf> {
            new Brille("Brille"), new Gnavpot("Gnavpot"), new Lystig("Lystig"),
            new Prosit("Prosit"), new Flovmand("Flovmand"), new Søvnig("Søvnig"),
            new Dumpe("Dumpe")};

        public List<Dwarf> CreateDwarfsList()
        {
            List <Dwarf> dwarfs = new List<Dwarf>();
            int amount_of_dwarfs = rnd.Next(2, 7);
            int dwarf;
            for(int i = 0; i < amount_of_dwarfs; i++)
            {
                dwarf = rnd.Next(0, total_dwarfs-1-i);
                dwarfs.Add(all_dwarfs[dwarf]);
                all_dwarfs.Remove(all_dwarfs[dwarf]);
            }
            return dwarfs;
        }
    }
}
