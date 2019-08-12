using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente
                = new Cliente();

            cliente.Nombre = "Emiliano zapata";
            cliente.Telefono = "644521584";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Telefono " + cliente.Telefono);
            try
            {

                cliente.Curp ="111111111111111111";
                Console.WriteLine("Curp: " + cliente.Curp);
            }
            catch(Exception e)
            {
                Console.WriteLine("La Curp debe ser de 18 caracteres");

            }


            Console.Read();
        }
    }
}
