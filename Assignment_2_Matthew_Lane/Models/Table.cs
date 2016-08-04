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
        public virtual int Id { get; set; }

        public virtual int FoodType { get; set; }

        [Required]
        public virtual string FoodName { get; set; }

        [Column(TypeName = "money")]
        public virtual decimal FoodPrice { get; set; }

        [Required]
        public virtual string FoodDescription { get; set; }
    }
}
