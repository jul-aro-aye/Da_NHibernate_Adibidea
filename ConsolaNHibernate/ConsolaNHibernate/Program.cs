using ConsolaNHibernate.Controladores;
using ConsolaNHibernate.Modeloak;
using System;
using System.Linq;

namespace ConsolaNHibernate
    {
        internal class Program
        {
            static ControladorUsuario controladorUsuario = new ControladorUsuario();

            static void Main(string[] args)
            {
                bool atera = false;
                while (!atera)
                {
                    Console.Clear();
                    Console.WriteLine("Aukeratu zeregina:");
                    Console.WriteLine("1. Erabiltzaileak bistaratu");
                    Console.WriteLine("2. Sortu erabiltzailea");
                    Console.WriteLine("3. Ezabatu erabiltzailea");
                    Console.WriteLine("4. Eguneratu erabiltzailea");
                    Console.WriteLine("5. Atera");
                    Console.Write("Aukera: ");
                    string aukera = Console.ReadLine();

                    switch (aukera)
                    {
                        case "1":
                            IkusiUsuarioak();
                            break;
                        case "2":
                            SortuUsuarioEtaDireccion();
                            break;
                        case "3":
                            EzabatuUsuarioa();
                            break;
                        case "4":
                            EguneratuUsuarioa();
                            break;
                        case "5":
                            atera = true;
                            break;
                        default:
                            Console.WriteLine("Operazio okerra. Sakatu teklaren bat berriro saiatzeko...");
                            Console.ReadKey();
                            break;
                    }
                }
            }

        private static void IkusiUsuarioak()
        {
            Console.WriteLine("\n=== Ikusi erabiltzaileak ===");
            var usuarios = controladorUsuario.ErabiltzaileakLortu();

            foreach (var usuario in usuarios)
            {
                Console.WriteLine("ID: {0}, Usuario: {1}, Nombre: {2}, Email: {3}, Ciudad: {4}, CP: {5}",
                    usuario.Idx, usuario.UsuarioNombre, usuario.Nombre, usuario.Email, usuario.Direccion.Ciudad, usuario.Direccion.CodigoPostal);
            }

            Console.WriteLine("Sakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }
        private static void SortuUsuarioEtaDireccion()
        {

            var nuevoUsuario = new Usuario
            {
                UsuarioNombre = "jul_aro_aye",
                Nombre = "Julen",
                Email = "julen@gmail.com"
            };

            var nuevoDireccion = new Direccion
            {
                Calle = "Calle Falsa 123",
                Ciudad = "Springfield",
                CodigoPostal = "12345",
                Usuario = nuevoUsuario
            };

            nuevoUsuario.Direccion = nuevoDireccion;

            controladorUsuario.ErabiltzaileaSortu(nuevoUsuario);

            Console.WriteLine("Erabiltzailea ongi ezarrita.\nSakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }


        private static void EzabatuUsuarioa()
        {
            
        }

        private static void EguneratuUsuarioa()
        {
            
        }

    }
}
