namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.dossier")]
    public partial class dossier
    {
        public int id { get; set; }

        [StringLength(255)]
        public string cin { get; set; }

        [StringLength(255)]
        public string diplomes { get; set; }

        [StringLength(255)]
        public string etatdossier { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        public int? utilisateur_id { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
