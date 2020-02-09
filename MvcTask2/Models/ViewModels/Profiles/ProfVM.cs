using MvcTask1.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTask1.Models.ViewModels.Profiles
{
    public class ProfVM
    {
        public ProfVM()
        {

        }
        public ProfVM(ProfDTO row)
        {
            Id = row.Id;
            Name = row.Name;
            Email = row.Email;
            Surname = row.Surname;
            Password = row.Password;
            Age = row.Age;
            Gender = row.Gender;
        }
    
        public int Id { get; set; }
        // ВАЛИДАЦИЯ
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 5)]
        public string Surname { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 5)]
        public string Password { get; set; }
      
        public int Age { get; set; }
        [Display(Name = "Gender")]
        public bool Gender { get; set; }
    
    }
}