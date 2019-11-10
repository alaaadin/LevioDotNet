namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.utilisateur")]
    public partial class utilisateur
    {
        public int id { get; set; }

        [StringLength(255)]
        public string login { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string password { get; set; }
    }
}
