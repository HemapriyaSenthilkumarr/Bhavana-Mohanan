using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace Productregistration.Models
{
    public class Category { 


        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public int MRP { get; set; }
        [Required]
        public  int Weight { get; set; }
        [Required]
        public int Discount { get; set; }
        [Required]
        public int Finalprice { get; set; }

    }
}
