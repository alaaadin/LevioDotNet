namespace DomainLevio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.client")]
    public partial class client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        public float Latitude { get; set; }

        [StringLength(255)]
        public string Logo { get; set; }

        public float Longitude { get; set; }

        public int? Typeclient { get; set; }

        public int? categories { get; set; }

        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }
    }
}
