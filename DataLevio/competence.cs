namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.competence")]
    public partial class competence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public competence()
        {
            ressource = new HashSet<ressource>();
        }

        [Key]
        public int idCompetence { get; set; }

        [StringLength(255)]
        public string Competences { get; set; }

        public DateTime? DateMiseAJour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ressource> ressource { get; set; }
    }
}
