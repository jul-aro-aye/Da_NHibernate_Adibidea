using ConsolaNHibernate.Modeloak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Controladores
{
    internal class ControladorUsuario
    {
        public void ErabiltzaileaSortu(Usuario erabiltzaileBerria)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(erabiltzaileBerria);
                transaction.Commit();
            }
        }

        public void ErabiltzaileaEguneratu(Usuario eguneratutakoErabiltzailea)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Update(eguneratutakoErabiltzailea);
                transaction.Commit();
            }
        }

        public void ErabiltzaileaEzabatu(int idErabiltzailea)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var erabiltzailea = session.Get<Usuario>(idErabiltzailea);
                if (erabiltzailea != null)
                {
                    session.Delete(erabiltzailea);
                    transaction.Commit();
                }
            }
        }

        public IList<Usuario> ErabiltzaileakLortu()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                return session.Query<Usuario>().ToList();
            }
        }

        public Usuario ErabiltzaileaLortu(int idErabiltzailea)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var erabiltzailea = session.Get<Usuario>(idErabiltzailea);
                // Lazily load eskariak ez emateko
                // NHibernateUtil.Initialize(erabiltzailea.Eskariak);

                return erabiltzailea;
            }
        }

        public IList<Usuario> ErabiltzaileaLortuMailaEtaAktiboagatik(Byte maila, bool aktibo)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<Usuario>()
                              .Where(u => u.Nombre == "Ane")
                              .ToList();
            }
        }

        

    }
}
