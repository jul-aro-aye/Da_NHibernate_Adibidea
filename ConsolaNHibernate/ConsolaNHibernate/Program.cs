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

        private static void IkusiUsuarioak()
        {
            Console.WriteLine("\n=== Ikusi erabiltzaileak ===");
            var usuarios = controladorUsuario.ErabiltzaileakLortu();

            foreach (var usuario in usuarios)
            {
                Console.WriteLine("ID: {0}, Usuario: {1}, Nombre: {2}, Email: {3}",
                    usuario.Idx, usuario.UsuarioNombre, usuario.Nombre, usuario.Email);
            }

            Console.WriteLine("Sakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }

        private static void SortuUsuario()
        {
            Console.WriteLine("\n=== Ezarri erabiltzaile berria ===");

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

            controladorUsuario.ErabiltzaileaSortu(nuevoUsuario);

            Console.WriteLine("Erabiltzailea ongi ezarrita.\nSakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }


        private static void EzabatuUsuarioa()
        {
            Console.WriteLine("\n=== Ezabatu usuario ===");
            Console.Write("Usuario id ezabatzeko: ");

            if (int.TryParse(Console.ReadLine(), out int usuarioId))
            {
                controladorUsuario.ErabiltzaileaEzabatu(usuarioId);
                Console.WriteLine("Usuarioa ongi ezabatu da.");
            }
            else
            {
                Console.WriteLine("ID baliogabea.");
            }

            Console.WriteLine("Sakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }

        private static void EguneratuUsuarioa()
        {
            Console.WriteLine("\n=== Eguneratu usuario ===");
            Console.Write("Usuario id eguneratzeko: ");

            if (int.TryParse(Console.ReadLine(), out int usuarioId))
            {
                var usuario = controladorUsuario.ErabiltzaileaLortu(usuarioId);
                if (usuario != null)
                {
                    Console.Write($"Nuevo nombre (ahora: {usuario.Nombre}): ");
                    string nuevoNombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nuevoNombre))
                        usuario.Nombre = nuevoNombre;

                    Console.Write($"Nuevo email (ahora: {usuario.Email}): ");
                    string nuevoEmail = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nuevoEmail))
                        usuario.Email = nuevoEmail;

                    controladorUsuario.ErabiltzaileaEguneratu(usuario);
                    Console.WriteLine("Erabiltzailea egoki eguneratuta.");
                }
                else
                {
                    Console.WriteLine("Erabiltzailea ez da aurkitu.");
                }
            }
            else
            {
                Console.WriteLine("ID okerra.");
            }

            Console.WriteLine("Sakatu tekla bat jarraitzeko...");
            Console.ReadKey();
        }

    }
}
