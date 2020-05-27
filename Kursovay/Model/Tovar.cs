namespace Kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tovar")]
    public partial class Tovar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tovar()
        {
            Sdelka = new HashSet<Sdelka>();
        }

        [Key]
        public int idtovar { get; set; }

        [Required]
        [StringLength(50)]
        public string nameTovar { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        [StringLength(20)]
        public string sort { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        public int ostatok { get; set; }

        [Required]
        [StringLength(50)]
        public string town { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sdelka> Sdelka { get; set; }
    }
}
