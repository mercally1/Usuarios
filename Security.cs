using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Security
    {
        public int Id { get; set; }
        public string security { get; set; }
        public int nivel { get; set; }

        public decimal grado { get; set; }

        public DateTime DateTime { get; set; }

        public string Seguridad() 
        {
            return $"Su nivel de acceso es de {this.nivel} con  {this.grado} que registra el dia {DateTime}";
        }
    }
}
