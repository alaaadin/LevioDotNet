namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.organigramme")]
    public partial class organigramme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public organigramme()
        {
            projet = new HashSet<projet>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrg { get; set; }

        [StringLength(255)]
        public string NomDir { get; set; }

        [StringLength(255)]
        public string NomHauteDir { get; set; }

        [StringLength(255)]
        public string Pvp { get; set; }

        [StringLength(255)]
        public string Vp { get; set; }

        public int idClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projet> projet { get; set; }
    }
}
