namespace Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuItem")]
    public partial class MenuItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string LongDescrition { get; set; }

        [Required]
        [StringLength(50)]
        public string Thumbnail { get; set; }

        [Required]
        [StringLength(50)]
        public string HighResolution { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemType { get; set; }
    }
}
