namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.parrain")]
    public partial class parrain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parrain()
        {
            candidat = new HashSet<candidat>();
        }

        [Key]
        public int idPar { get; set; }

        public int age { get; set; }

        [StringLength(255)]
        public string mail { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        public int? parrainIdToBeUpdated { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        public int tel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidat> candidat { get; set; }
    }
}
