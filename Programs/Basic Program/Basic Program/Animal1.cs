using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Animal1
    {
        private int chickens;
        private int cows;
        private int pigs;

        public Animal1(int chickens, int cows, int pigs)
        {
            this.Chickens = chickens;
            this.Cows = cows;
            this.Pigs = pigs;
        }

        public int Chickens { get => chickens; set => chickens = value; }
        public int Cows { get => cows; set => cows = value; }
        public int Pigs { get => pigs; set => pigs = value; }

        public int count_legs()
        {
            int result = (this.Chickens * 2) + (this.Cows * 4) + (this.Pigs * 4);
            return result;
        }
    }
}
