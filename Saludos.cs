using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Saludos
    {
        public int id { get; set; }
        public string name { get; set; }

        public string Hola()
        {
            return $"{this.name}";
        }
    }
}
