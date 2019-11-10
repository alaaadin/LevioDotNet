namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.message")]
    public partial class message
    {
        [Key]
        public int idmessage { get; set; }

        [StringLength(255)]
        public string contenu { get; set; }

        [StringLength(255)]
        public string reciever { get; set; }

        [StringLength(255)]
        public string sender { get; set; }

        [StringLength(255)]
        public string subject { get; set; }
    }
}
