using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcLogin.Models.VM
{
    public class LoginVM
    {


        [
            EmailAddress(ErrorMessage = "E-Posta adresiniz dogru formatta değil"), Required(ErrorMessage = "Eposta alanı zorunludur."),
            DisplayName("E-Posta")
            ]
        public string Email { get; set; }
        [
           Required(ErrorMessage = "Paralo alanı zorunludur."),
           DisplayName("Parola")
           ]
        public string Password { get; set; }



        [

          DisplayName("Beni Hatırla")
          ]
        public bool IsPersistant { get; set; }
    }
}