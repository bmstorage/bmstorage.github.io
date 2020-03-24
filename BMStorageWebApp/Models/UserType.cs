using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class UserType
   {
      [Display(Name = "User Type ID")]
      public int UserTypeID { get; set; }
      public string Type { get; set; }

   }
}