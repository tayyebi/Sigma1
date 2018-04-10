namespace Core.RexaModel.ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentSet")]
    public partial class DocumentSet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int ResumeId { get; set; }

        public int Lenght { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        public byte[] Binaries { get; set; }

        public virtual Logger Logger { get; set; }

        public virtual ResumeSet ResumeSet { get; set; }
    }
}
