using ConsolaNHibernate.Modeloak;
using System;
using System.Linq;

namespace ConsolaNHibernate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean atera = false;
            while (!atera)
            {
                Console.Clear();
                Console.WriteLine("Aukeratu zeregina:");
                Console.WriteLine("1. Erabiltzaileak bistaratu");
                Console.WriteLine("2. Sortu erabiltzailea");
                Console.WriteLine("3. Ezabatu erabiltzailea");
                Console.WriteLine("4. Eguneratu erabiltzailea");
                Console.WriteLine("5. Atera");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        IkusiUsuarioak();
                        break;
                    case "2":
                        SortuUsuario();
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

        private static void SortuUsuario()
        {
            Console.WriteLine("\n=== Insertar nuevo usuario ===");

            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            var nuevoUsuario = new Usuario
            {
                UsuarioNombre = usuario,
                Nombre = nombre,
                Email = email
            };

            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(nuevoUsuario);
                transaction.Commit();
            }

            Console.WriteLine("Erabiltzailea ongi ezarrita.\nSakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }

        private static void SortuDireccion()
        {
            Console.WriteLine("\n=== Crear nueva dirección ===");

            Console.Write("Calle: ");
            string calle = Console.ReadLine();

            Console.Write("Ciudad: ");
            string ciudad = Console.ReadLine();

            Console.Write("Código Postal: ");
            string codigoPostal = Console.ReadLine();

            var nuevaDireccion = new Direccion
            {
                Calle = calle,
                Ciudad = ciudad,
                CodigoPostal = codigoPostal
            };

            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(nuevaDireccion);
                transaction.Commit();
            }

            Console.WriteLine("Helbidea egoki ezarrita.\nSakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }
    }
}
