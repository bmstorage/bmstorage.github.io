using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class AccountType
   {
      [Display(Name = "Account Type ID")]
      public int AccountTypeID { get; set; }

      public string AccountTypeName { get; set; }
      
   }
}