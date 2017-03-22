namespace KaficBeertija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Artikl")]
    public partial class Artikl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artikl()
        {
            Stavke_narudzbenice = new HashSet<Stavke_narudzbenice>();
            Stavke_racuna = new HashSet<Stavke_racuna>();
        }

        [Key]
        public int ID_artikl { get; set; }

        [StringLength(50)]
        public string Naziv { get; set; }

        public double? Cijena { get; set; }

        public int? Kolicina { get; set; }

        public int ID_vrsta_artikla { get; set; }

        public virtual Vrsta_artikla Vrsta_artikla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavke_narudzbenice> Stavke_narudzbenice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavke_racuna> Stavke_racuna { get; set; }
    }
}
