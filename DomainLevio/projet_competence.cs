namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leviobd.projet_competence")]
    public partial class projet_competence
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Projet_idProjet { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int competences_idCompetence { get; set; }

        public virtual competence competence { get; set; }
    }
}
