using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class User
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        public string TUser { get; set; }
        public string Password { get; set; }

        private static void Pass()
        {
           string  pass=" as123_1";
            if (pass == "as123_1")
            {
                Console.WriteLine("Usuario valido");
            }
            else
            {
                Console.WriteLine("Usuario invalido");
            }
        }
            

        public string ShowData()
        {
            return $"ID: {this.ID}\n Nombre: {this.Name}\n Usuario: {this.TUser}\n Password: {this.Password}\n";
        }
    }
}
