namespace Core.RexaModel.ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Logger")]
    public partial class Logger
    {
        [Key]
        public int IndexId { get; set; }

        [Required]
        [StringLength(50)]
        public string MasterId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EventDateTime { get; set; }

        public bool IsDeleted { get; set; }

        public virtual AdminSet AdminSet { get; set; }

        public virtual DocumentSet DocumentSet { get; set; }

        public virtual EducationSet EducationSet { get; set; }

        public virtual JobSet JobSet { get; set; }

        public virtual ResumeSet ResumeSet { get; set; }

        public virtual UserSet UserSet { get; set; }
    }
}
