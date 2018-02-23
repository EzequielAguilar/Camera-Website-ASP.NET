namespace assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class camera
    {
        public int cameraID { get; set; }

        [Required]
        [StringLength(10)]
        public string Type { get; set; }

        public int Megapixels { get; set; }

        [Column(TypeName = "money")]
        public decimal cameraPrice { get; set; }

        public int companyID { get; set; }
    }
}
