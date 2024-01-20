using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class AlmacenSn
    {
        static void Main(string[] args)
        {
            
            Saludos osaludo = new Saludos();
            osaludo.name = "bienvenido a este programa\n ";
            Console.WriteLine(osaludo.name);
           
            User s = new User();
            s.ID = 1;
            s.Name = "jorge";
            s.TUser = "gerente";
            s.Password = "pas123_1";

            User.pass = new User();
            //hola soy un duketo y enla linea 2y7 
            //donn los demas que coman los demas 


            Department d = new Department();
            d.Departament = "gerencia\n";

            Security security = new Security();
            security.nivel = 2;
            security.grado = 0.56m;
            security.DateTime = DateTime.Now;



            Console.WriteLine(security.ToString());

            Console.WriteLine(s.ShowData() + d.Name1() + security.Seguridad());
            Console.ReadLine();
        }
    }
}
