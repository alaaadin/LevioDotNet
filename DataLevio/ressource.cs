namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.ressource")]
    public partial class ressource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ressource()
        {
            mandat = new HashSet<mandat>();
            competence = new HashSet<competence>();
        }

        [Key]
        public int idRessource { get; set; }

        [StringLength(255)]
        public string cv { get; set; }

        public DateTime? dateDebut { get; set; }

        public DateTime? dateFin { get; set; }

        [StringLength(255)]
        public string historique { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [StringLength(255)]
        public string origine { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string profil { get; set; }

        [StringLength(255)]
        public string secteur { get; set; }

        [StringLength(255)]
        public string seniorite { get; set; }

        [StringLength(255)]
        public string statut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mandat> mandat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<competence> competence { get; set; }
    }
}
