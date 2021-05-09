namespace WebApplication2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login")]
    public partial class login
    {
        [Key]
        [StringLength(50)]
        public string user { get; set; }

        [StringLength(50)]
        public string pass { get; set; }
    }
}
