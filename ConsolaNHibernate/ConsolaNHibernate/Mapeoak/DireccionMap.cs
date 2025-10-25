using FluentNHibernate.Conventions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaNHibernate.Modeloak;
using FluentNHibernate.Mapping;


namespace ConsolaNHibernate.Mapeoak
{
    public class DireccionMap : ClassMap<Direccion>
    {
        public DireccionMap()
        {
            Table("helbideak"); // ← Taularen izen erreala jarri
            Id(x => x.Idx).Column("idx").GeneratedBy.Identity();
            Map(x => x.Calle).Column("calle").Length(50);
            Map(x => x.Ciudad).Column("ciudad").Length(30);
            Map(x => x.CodigoPostal).Column("codigoPostal").Length(10);
            References(x => x.Usuario)
                .Column("usuario_idx") // ← Erabiltzailearen idx atala duen zutabea
                .Unique();
        }
    }
}
