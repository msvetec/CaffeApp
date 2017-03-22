namespace KaficBeertija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stavke_racuna
    {
        [Key]
        public int ID_stavke_racuna { get; set; }

        public int ID_artikl { get; set; }

        public int? ID_racun { get; set; }

        public virtual Artikl Artikl { get; set; }

        public virtual Racuni Racuni { get; set; }
    }
}
