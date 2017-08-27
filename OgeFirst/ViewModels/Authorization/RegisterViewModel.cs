using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels.Authorization
{
    public class RegisterViewModel
    {
        public string Email { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public RegistrationDTO ToDTO()
        {
            return new RegistrationDTO { Email = this.Email, Password = this.Password };
        }
    }
}