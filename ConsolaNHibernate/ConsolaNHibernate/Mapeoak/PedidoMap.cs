using ConsolaNHibernate.Modeloak;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaNHibernate.Mapeoak
{
    public class PedidoMap : ClassMap<Pedido>
    {
        public PedidoMap()
        {
            Table("pedidos"); // ← Taularen izen erreala jarri
            Id(x => x.Id).Column("idx").GeneratedBy.Identity();
            Map(x => x.Fecha).Column("data");
            Map(x => x.Total).Column("zanbatekoa");
            References(x => x.Usuario)
                .Column("usuario_idx"); // Erabiltzailearen foreign key
        }
    }
}
