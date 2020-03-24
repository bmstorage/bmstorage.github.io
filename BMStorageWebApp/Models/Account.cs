using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class Account
   {
      [Display(Name = "Account ID")]
      public int AccountID { get; set; }

      [Display(Name = "Account Type ID")]
      public int AccountTypeID { get; set; }

      [Display(Name = "User ID")]
      public int UserID { get; set; }
      
   }
}