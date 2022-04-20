using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Car
    {
        public string Model { get; set; }
        public bool HasMalfunction { get; set; }
        public string Error { get; set; } 
    }
}
