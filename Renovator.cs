using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        /fields
        private string name;
        private string vid;
        private decimal rate;
        private int days;
        private bool hired;
        
        //Constructors

        public Renovator(string name, string vid, decimal rate, int days)
        {
            Name = name;
            Vid = vid;
            Rate = rate;
            Days = days;
            Hired = false;
        }

        //Prop
        public string Name { get; set; }
        public string Vid { get; set; }
        public decimal Rate { get; set; }
        public int Days { get; set; }
        public bool Hired { get; set; }

    }
}
