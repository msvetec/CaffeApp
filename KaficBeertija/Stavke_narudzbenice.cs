namespace KaficBeertija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stavke_narudzbenice
    {
        [Key]
        public int ID_stavke_narudzbenice { get; set; }

        public int? Kolicina { get; set; }

        public int ID_narudzbenica { get; set; }

        public int ID_artikl { get; set; }

        public virtual Artikl Artikl { get; set; }

        public virtual Narudzbenica Narudzbenica { get; set; }
    }
}
