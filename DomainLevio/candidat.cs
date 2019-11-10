namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.candidat")]
    public partial class candidat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public candidat()
        {
            parrain = new HashSet<parrain>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string etat { get; set; }

        public int? demande_idDemande { get; set; }

        public virtual demande demande { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parrain> parrain { get; set; }
    }
}
