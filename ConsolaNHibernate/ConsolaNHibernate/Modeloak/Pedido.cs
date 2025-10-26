using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Modeloak
{
    public class Pedido
    {
        public virtual int Idx { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual decimal Total { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}
