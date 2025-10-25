using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Modeloak
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        
    }
}
