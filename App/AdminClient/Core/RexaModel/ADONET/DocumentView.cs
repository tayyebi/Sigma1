namespace Core.RexaModel.ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentView")]
    public partial class DocumentView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IndexId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MasterId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime EventDateTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResumeId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Lenght { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte[] Binaries { get; set; }
    }
}
