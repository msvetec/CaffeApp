namespace KaficBeertija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Racuni")]
    public partial class Racuni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racuni()
        {
            Stavke_racuna = new HashSet<Stavke_racuna>();
        }

        [Key]
        public int ID_racuni { get; set; }

        public double? Iznos { get; set; }

        public int? ID_korisnik { get; set; }

        public int? ID_kafic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum_kreiranja { get; set; }

        public virtual Kafic Kafic { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavke_racuna> Stavke_racuna { get; set; }
    }
}
