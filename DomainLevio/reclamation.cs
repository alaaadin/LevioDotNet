namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.reclamation")]
    public partial class reclamation
    {
        [Key]
        public int idreclamation { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime? daterec { get; set; }

        [StringLength(255)]
        public string deftype { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string etatreclamation { get; set; }

        [StringLength(255)]
        public string typereclamation { get; set; }

        public int? reponse_idrep { get; set; }

        public virtual reponsereclamation reponsereclamation { get; set; }
    }
}
