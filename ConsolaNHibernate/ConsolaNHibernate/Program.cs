using ConsolaNHibernate.Modeloak;
using System;
using System.Linq;

namespace ConsolaNHibernate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Aukeratu zeregina:");
                Console.WriteLine("1. Sortu erabiltzailea");
                Console.WriteLine("2. Sortu helbide berria");
                Console.WriteLine("3. Atera");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        SortuUsuario();
                        break;
                    case "2":
                        SortuDireccion();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para intentar de nuevo...");
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

            Console.WriteLine("Usuario insertado correctamente.\nPresione una tecla para continuar...");
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

            Console.WriteLine("Dirección creada correctamente.\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
