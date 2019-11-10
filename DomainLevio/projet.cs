namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.projet")]
    public partial class projet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public projet()
        {
            mandat = new HashSet<mandat>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProjet { get; set; }

        public float Benefice { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public int NbrRessource { get; set; }

        [StringLength(255)]
        public string NomProjet { get; set; }

        public float Rentabilite { get; set; }

        public int? organigramme_IdOrg { get; set; }
        
        public int? client_id { get; set; }

        [StringLength(255)]
        public string Typeprojet { get; set; }

        public virtual client client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mandat> mandat { get; set; }

        public virtual organigramme organigramme { get; set; }
    }
}
