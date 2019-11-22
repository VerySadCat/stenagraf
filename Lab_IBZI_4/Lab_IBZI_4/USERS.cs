namespace Lab_IBZI_4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [Key]
        [StringLength(255)]
        public string login { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        public int idStat { get; set; }

        [Required]
        [StringLength(255)]
        public string FIO { get; set; }

        [StringLength(255)]
        public string foto { get; set; }

        public virtual STATUSES STATUSES { get; set; }
    }
}
