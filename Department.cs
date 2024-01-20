using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Department : User
    {
        public int IdDepartament { get; set; }

        public string Departament { get; set; }

        public string Name1()
        {
            return $"Departamento:{this.Departament}";
        }
    }
}
