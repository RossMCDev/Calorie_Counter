namespace WalkOffCalories.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Walk")]
    public partial class Walk
    {
        [Key]
        public int Walk_ID { get; set; }

        [Required(ErrorMessage = "Please enter your weight in pounds.")]
        [Range(1, 1500)]
        public double PersonHeaviness { get; set; }

        [Required(ErrorMessage = "Please enter your height in feet and inches.")]
        [Range(1, 11)]
        public double PersonFeet { get; set; }
        public double PersonInches { get; set; }


        [Required(ErrorMessage = "Please enter how many miles you are walking.")]
        [Range(0,100)]
        public double Distance { get; set; }

        [Required]
        [Range(0, 11)]
        public int WalkHours { get; set; }

        [Required(ErrorMessage = "Please enter duration in hours:minutes:seconds.")]
        [Range(0, 59)]

        public int WalkMinutes { get; set; }

        [Required]
        [Range(0, 59)]
        public int WalkSeconds { get; set; }

        public double CalorieCount { get; set; }
    }
}
