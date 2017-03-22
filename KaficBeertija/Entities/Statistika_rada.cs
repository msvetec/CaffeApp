namespace KaficBeertija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Statistika_rada
    {
        [Key]
        public int ID_statistika_rada { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Od { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Do { get; set; }

        public double? UkupniPromet { get; set; }

        public int ID_korisnik { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
