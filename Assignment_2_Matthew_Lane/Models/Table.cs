namespace Assignment_2_Matthew_Lane.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        public int Id { get; set; }

        public int FoodType { get; set; }

        [Required]
        public string FoodName { get; set; }

        [Column(TypeName = "money")]
        public decimal FoodPrice { get; set; }

        [Required]
        public string FoodDescription { get; set; }
    }
}
