namespace Core.RexaModel.ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserView")]
    public partial class UserView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MasterId { get; set; }

        public int? IndexId { get; set; }

        public int? UpdatesCount { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public byte[] Image { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Lastname { get; set; }
    }
}
