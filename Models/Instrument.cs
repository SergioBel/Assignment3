namespace Assignment3WADB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Instrument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instrumentID { get; set; }

        [StringLength(50)]
        public string instrumentName { get; set; }

        public int? instrumentPrice { get; set; }

        public int? workerID { get; set; }

        public int? jobID { get; set; }
        [ForeignKey("jobID")]
        public virtual Job Job { get; set; }
        [ForeignKey("workerID")]
        public virtual Worker Worker { get; set; }
    }
}
