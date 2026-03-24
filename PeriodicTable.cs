using System;
using System.Collections.Generic;

namespace PeriodicTableSystem
{
    public class PeriodicTable
    {
        private Dictionary<int, Element> elements;

        public PeriodicTable()
        {
            elements = new Dictionary<int, Element>();
            InitializeElements();
        }

        private void InitializeElements()
        {
            elements.Add(1, new Element(1, "Hydrogen", "H", "Nonmetal", 1.008, "Lightest element, forms water, most abundant in universe"));
            elements.Add(2, new Element(2, "Helium", "He", "Nonmetal", 4.003, "Noble gas, used in balloons and airships, second most abundant"));
            elements.Add(3, new Element(3, "Lithium", "Li", "Metal", 6.941, "Alkali metal, soft and silvery, used in batteries"));
            elements.Add(4, new Element(4, "Beryllium", "Be", "Metal", 9.012, "Transition metal, lightweight, used in aerospace"));
            elements.Add(5, new Element(5, "Boron", "B", "Metalloid", 10.811, "Used in glass and ceramics, important for plant growth"));
            elements.Add(6, new Element(6, "Carbon", "C", "Nonmetal", 12.011, "Forms diamonds and graphite, backbone of organic chemistry"));
            elements.Add(7, new Element(7, "Nitrogen", "N", "Nonmetal", 14.007, "Makes up 78% of atmosphere, essential for proteins"));
            elements.Add(8, new Element(8, "Oxygen", "O", "Nonmetal", 15.999, "Essential for respiration, makes up 21% of atmosphere"));
            elements.Add(9, new Element(9, "Fluorine", "F", "Nonmetal", 18.998, "Most reactive element, used in refrigerants"));
            elements.Add(10, new Element(10, "Neon", "Ne", "Nonmetal", 20.180, "Noble gas, used in neon signs, glows red when excited"));
            elements.Add(11, new Element(11, "Sodium", "Na", "Metal", 22.990, "Alkali metal, essential for nerve function and salt"));
            elements.Add(12, new Element(12, "Magnesium", "Mg", "Metal", 24.305, "Alkaline earth metal, important for photosynthesis"));
            elements.Add(13, new Element(13, "Aluminum", "Al", "Metal", 26.982, "Lightweight metal, widely used in construction and packaging"));
            elements.Add(14, new Element(14, "Silicon", "Si", "Metalloid", 28.086, "Used in computer chips and solar cells"));
            elements.Add(15, new Element(15, "Phosphorus", "P", "Nonmetal", 30.974, "Essential for bone formation and energy transfer in cells"));
            elements.Add(16, new Element(16, "Sulfur", "S", "Nonmetal", 32.065, "Yellow nonmetal, important for protein structure"));
            elements.Add(17, new Element(17, "Chlorine", "Cl", "Nonmetal", 35.453, "Used to disinfect water, forms salts with metals"));
            elements.Add(18, new Element(18, "Argon", "Ar", "Nonmetal", 39.948, "Noble gas, used in welding and light bulbs"));
            elements.Add(19, new Element(19, "Potassium", "K", "Metal", 39.098, "Alkali metal, essential for muscle and heart function"));
            elements.Add(20, new Element(20, "Calcium", "Ca", "Metal", 40.078, "Alkaline earth metal, essential for bones and teeth"));
            elements.Add(21, new Element(21, "Scandium", "Sc", "Metal", 44.956, "Rare earth element, used in aerospace applications"));
            elements.Add(22, new Element(22, "Titanium", "Ti", "Metal", 47.867, "Strong and lightweight, used in aircraft and medical implants"));
            elements.Add(23, new Element(23, "Vanadium", "V", "Metal", 50.942, "Transition metal, used to strengthen steel alloys"));
            elements.Add(24, new Element(24, "Chromium", "Cr", "Metal", 51.996, "Used for plating and stainless steel production"));
            elements.Add(25, new Element(25, "Manganese", "Mn", "Metal", 54.938, "Transition metal, used in steel and battery production"));
            elements.Add(26, new Element(26, "Iron", "Fe", "Metal", 55.845, "Most widely used metal, essential for blood oxygen transport"));
            elements.Add(27, new Element(27, "Cobalt", "Co", "Metal", 58.933, "Magnetic metal, used in battery and alloy production"));
            elements.Add(28, new Element(28, "Nickel", "Ni", "Metal", 58.693, "Corrosion resistant, used in coinage and alloys"));
            elements.Add(29, new Element(29, "Copper", "Cu", "Metal", 63.546, "Excellent conductor, used in electrical wiring and coins"));
            elements.Add(30, new Element(30, "Zinc", "Zn", "Metal", 65.409, "Used in galvanization and brass production, essential mineral"));
        }

        public Element GetElement(int atomic_number)
        {
            if (elements.ContainsKey(atomic_number))
            {
                return elements[atomic_number];
            }
            return null;
        }

        public bool ElementExists(int atomic_number)
        {
            return elements.ContainsKey(atomic_number);
        }

        public int GetTotalElements()
        {
            return elements.Count;
        }

        public Dictionary<int, Element> GetAllElements()
        {
            return elements;
        }
    }
}
