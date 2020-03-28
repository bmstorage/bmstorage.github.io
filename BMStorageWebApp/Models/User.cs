using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class User
   {
      [Display(Name = "User ID")]
      public int UserID { get; set; }

      [Display(Name = "User Type ID")]
      public int UserTypeID { get; set; }

      [Display(Name = "Gate Code")]
      public string GateCode { get; set; }

      [Display(Name = "First Name")]
      public string FirstName { get; set; }

      [Display(Name = "Last Name")]
      public string LastName { get; set; }

      public string Email { get; set; }

      public string Phone { get; set; }

      [Display(Name = "Street Address")]
      public string StreetAddress { get; set; }
      public string City { get; set; }

      public string State { get; set; }

      public string Zip { get; set; }


      /* Navigation Properties */

      public UserType UserType { get; set; }

      //public ICollection<Unit> Units { get; set; }

   }
}