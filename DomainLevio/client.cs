namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.client")]
    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            projet = new HashSet<projet>();
            organigramme = new HashSet<organigramme>();
        }

        public int id { get; set; }

        public int Latitude { get; set; }

        [StringLength(255)]
        public string Logo { get; set; }

        public int Longitude { get; set; }

        [StringLength(255)]
        public string Typeclient { get; set; }

        [StringLength(255)]
        public string categories { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projet> projet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<organigramme> organigramme { get; set; }
    }
}
