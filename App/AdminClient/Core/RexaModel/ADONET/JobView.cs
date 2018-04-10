namespace Core.RexaModel.ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobView")]
    public partial class JobView
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
    }
}
