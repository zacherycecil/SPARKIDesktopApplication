using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPARKIDesktopApp
{
    public class Electrode
    {
        public string name;

        // Therapeutic
        public int[] therapeuticValues;

        public Electrode(string name)
        {
            this.name = name;
            therapeuticValues = new int[8];
        }
    }
}
