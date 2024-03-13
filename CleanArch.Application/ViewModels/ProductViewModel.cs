using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(5)]
        [MaxLength(200)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The Price is Required")]
        [Range(1, 999999.99)]
        [Display(Name = "Price")]


        public string Price { get; set; }



    }
}