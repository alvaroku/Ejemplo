using System;
using Ejemplo.Modelos;

namespace Ejemplo{
    class Program {
        static void Main(string[] args){
            /* Usuario _Usuario;
            _Usuario = new Usuario();
            _Usuario.Nombre = "Alvaro";
            _Usuario.Edad = 22;
            //error por ser privado
            //_Usuario.Correo = "alvaro123@gmail.com";
            _Usuario.SetCorreo("alvaro123@gmail.com");
            _Usuario.Contrasenia = "12345";
            _Usuario.Apellido = "Kú";
            Console.WriteLine(_Usuario.Info());
 */
            /* Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            int Edad = int.Parse(Console.ReadLine());

            Usuario _Usuario1 = new Usuario(Nombre,"Kú",Edad,"alvaro123@gmail.com","12345");
            Console.WriteLine(_Usuario1.Info());
 */
            Telefono[] Telefonos = new Telefono[]{
                new Telefono{CodigoPais = 52,Numero = "9919596929"},
                new Telefono{CodigoPais = 53,Numero = "9919596720"},
                new Telefono{CodigoPais = 55,Numero = "9919596720"}
            };
            foreach (Telefono item in Telefonos)
            {
                //Console.WriteLine(item.Info());
            }
            Usuario[] Usuarios = new Usuario[] {
                new Usuario("Alvaro","Kú",21,"alvaro123@gmail.com","12345",Telefonos[0]),
                new Usuario("Daniel","Uitz",22,"alvaro123@gmail.com","12345",Telefonos[1]),
                new Usuario("Alex","Xul",23,"alvaro123@gmail.com","12345",Telefonos[2]),
            };
            foreach(Usuario elem in Usuarios){
                Console.WriteLine(elem.Info());
                Console.WriteLine(elem.Telefono.Info());
            }
        }
    }
}