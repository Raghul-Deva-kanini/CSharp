using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Animals : College, Sound, AnimalType
    {
        private string name;
        private int eyes, mouth, legs, tail;

        public Animals(string name, int eyes, int mouth, int legs, int tail, string collegeName, string address, int pincode):base(collegeName, address, pincode) 
        {
            this.Name = name;
            this.Eyes = eyes;
            this.Mouth = mouth;
            this.Legs = legs;
            this.Tail = tail;
        }

        public string Name { get => name; set => name = value; }
        public int Eyes { get => eyes; set => eyes = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Legs { get => legs; set => legs = value; }
        public int Tail { get => tail; set => tail = value; }

        public void MakeSound(string name)
        {
            if (name == "dog")
                Console.WriteLine("Bow Bow");
            else if (name == "cat")
                Console.WriteLine("Meo Meo");
        }

        public void Type(string name)
        {
            if (name == "dog")
                Console.WriteLine("Carnovore");
            else if (name == "cow")
                Console.WriteLine("Herbivore");
        }
    }
}
