namespace Core.RexaModel.ADONET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobSet")]
    public partial class JobSet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public virtual Logger Logger { get; set; }

        public virtual ResumeSet ResumeSet { get; set; }
    }
}
