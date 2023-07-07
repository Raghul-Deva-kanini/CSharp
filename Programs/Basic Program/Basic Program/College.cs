using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class College
    {
        private string collegeName, address;
        private int pincode;

        public College(string collegeName, string address, int pincode)
        {
            this.CollegeName = collegeName;
            this.Address = address;
            this.Pincode = pincode;
        }

        public string CollegeName { get => collegeName; set => collegeName = value; }
        public string Address { get => address; set => address = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
}
