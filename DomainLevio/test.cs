namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.test")]
    public partial class test
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(255)]
        public string etattest { get; set; }

        [StringLength(255)]
        public string resultat { get; set; }

        [StringLength(255)]
        public string typetest { get; set; }

        public int? utilisateur_id { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
