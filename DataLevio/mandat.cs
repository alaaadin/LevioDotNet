namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.mandat")]
    public partial class mandat
    {
        [Key]
        public int idMandat { get; set; }

        [Column(TypeName = "bit")]
        public bool archive { get; set; }

        public DateTime? dateDebut { get; set; }

        public DateTime? dateFin { get; set; }

        public float frais { get; set; }

        public int? projet_idProjet { get; set; }

        public int? ressource_idRessource { get; set; }

        public virtual ressource ressource { get; set; }

        public virtual projet projet { get; set; }
    }
}
