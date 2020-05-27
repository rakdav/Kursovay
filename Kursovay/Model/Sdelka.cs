namespace Kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sdelka")]
    public partial class Sdelka
    {
        [Key]
        public int idSdelka { get; set; }

        public int Count { get; set; }

        public DateTime date { get; set; }

        public int idclient { get; set; }

        public int idtovar { get; set; }

        public virtual Client Client { get; set; }

        public virtual Tovar Tovar { get; set; }
    }
}
