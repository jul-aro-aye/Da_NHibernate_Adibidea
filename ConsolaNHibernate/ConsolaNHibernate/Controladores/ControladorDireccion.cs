using ConsolaNHibernate.Modeloak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Controladores
{
    internal class ControladorDireccion
    {
        public IList<Usuario> HelbdieakLortu()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<Usuario>().ToList();
            }
        }

        public Direccion HelbideaLortu(int idHelbidea)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Get<Direccion>(idHelbidea);
            }
        }
    }
}
