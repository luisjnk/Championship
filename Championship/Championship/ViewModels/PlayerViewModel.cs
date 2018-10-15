using System;
using System.ComponentModel.DataAnnotations;

namespace Championship.ViewModels
{
    public class PlayerViewModel
    {   [Key]
        public int PlayerId { get; set; }

        [Required(ErrorMessage = "Please, fill the field Name")]
        [MaxLength(100, ErrorMessage = "Name can't be greater than  {0} characters ")]
        [MinLength(5, ErrorMessage = "Name can't be less  than  {0} characters ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, fill the field Strength")]
        public int Strength { get; set; }

        [Required(ErrorMessage = "Please, fill the field Agillity")]
        public int Agillity { get; set; }

        [Required(ErrorMessage = "Please, fill the field Defense")]
        public int Defense { get; set; }
    }
}