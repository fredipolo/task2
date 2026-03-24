using System;

namespace PeriodicTableSystem
{
    public class Element
    {
        public int atomic_number { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string element_class { get; set; }
        public double atomic_mass { get; set; }
        public string information { get; set; }

        public Element()
        {
            atomic_number = 0;
            name = "";
            symbol = "";
            element_class = "";
            atomic_mass = 0.0;
            information = "";
        }

        public Element(int num, string elem_name, string sym, string elem_class, double mass, string info)
        {
            atomic_number = num;
            name = elem_name;
            symbol = sym;
            element_class = elem_class;
            atomic_mass = mass;
            information = info;
        }

        public string GetElementInfo()
        {
            return string.Format("Atomic Number: {0}\nName: {1}\nSymbol: {2}\nClass: {3}\nAtomic Mass: {4:F4}\nInformation: {5}",
                atomic_number, name, symbol, element_class, atomic_mass, information);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Atomic Number: {0}", atomic_number);
            Console.WriteLine("Name: {1}", name);
            Console.WriteLine("Symbol: {2}", symbol);
            Console.WriteLine("Class: {3}", element_class);
            Console.WriteLine("Atomic Mass: {4:F4}", atomic_mass);
            Console.WriteLine("Information: {5}", information);
        }
    }
}
