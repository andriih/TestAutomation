using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    [Serializable]
    public class Human
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public bool Registered { get; set; }

        public override string ToString()
        {
            return "Id : " + PersonID + " " + Name + " Registered: " + Registered;
        }
    }
}
