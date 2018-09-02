using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Dwarf> dwarfs = new List<Dwarf>();
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = input.Split(new string[] { " <:> " },
                    StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                int dwarfPhysics = int.Parse(tokens[2]);
                bool isExistingDwarf = false;
                for (int i = 0; i < dwarfs.Count; i++)
                {
                    Dwarf currentDwarf = dwarfs[i];
                    if (currentDwarf.DwarfName == dwarfName &&
                        currentDwarf.DwarfHatColor == dwarfHatColor)
                    {
                        int newPhysics = Math.Max(currentDwarf.DwarfPhysics, dwarfPhysics);
                        dwarfs[i] = new Dwarf(dwarfName, dwarfHatColor, newPhysics);
                        isExistingDwarf = true;
                    }
                }
                if (!isExistingDwarf)
                {
                    dwarfs.Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics));
                }
            }
            dwarfs = dwarfs
                .GroupBy(x => x.DwarfHatColor)
                .OrderByDescending(x => x.Count())
                .SelectMany(x => x)
                .OrderByDescending(x => x.DwarfPhysics)
                .ToList();

            foreach (Dwarf dwarf in dwarfs)
            {
                Console.WriteLine($"({dwarf.DwarfHatColor}) {dwarf.DwarfName} <-> {dwarf.DwarfPhysics}");
            }
        }
    }
    class Dwarf
    {
        public string DwarfName { get; set; }
        public string DwarfHatColor { get; set; }
        public int DwarfPhysics { get; set; }
        public Dwarf(string dwarfName, string dwarfHatColor, int dwarfPhysics)
        {
            this.DwarfName = dwarfName;
            this.DwarfHatColor = dwarfHatColor;
            this.DwarfPhysics = dwarfPhysics;
        }
    }
}
