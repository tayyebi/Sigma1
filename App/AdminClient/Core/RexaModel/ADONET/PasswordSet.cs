namespace Core.RexaModel.ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PasswordSet")]
    public partial class PasswordSet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Value { get; set; }

        public int UserId { get; set; }

        public virtual UserSet UserSet { get; set; }
    }
}
