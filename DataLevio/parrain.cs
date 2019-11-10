namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.parrain")]
    public partial class parrain
    {
        [Key]
        public int idPar { get; set; }

        public int? candidat_id { get; set; }

        public virtual candidat candidat { get; set; }
    }
}
