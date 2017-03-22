namespace KaficBeertija
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Narudzbenica")]
    public partial class Narudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzbenica()
        {
            Stavke_narudzbenice = new HashSet<Stavke_narudzbenice>();
        }

        [Key]
        public int ID_narudzbenica { get; set; }

        public DateTime? datum_kreiranja { get; set; }

        public int ID_dobavljac { get; set; }

        public int ID_korisnik { get; set; }

        public int ID_kafic { get; set; }

        public virtual Dobavljac Dobavljac { get; set; }

        public virtual Kafic Kafic { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavke_narudzbenice> Stavke_narudzbenice { get; set; }
    }
}
