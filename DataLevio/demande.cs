namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.demande")]
    public partial class demande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public demande()
        {
            candidat = new HashSet<candidat>();
        }

        [Key]
        public int idDemande { get; set; }

        public DateTime? DateDemande { get; set; }

        [StringLength(255)]
        public string EtatDemande { get; set; }

        [StringLength(255)]
        public string Specialite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidat> candidat { get; set; }
    }
}
