using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class User
   {
      [Display(Name = "User ID")]
      public int UserID { get; set; }

      public string GateCode { get; set; }

      public string FirstName { get; set; }
      
      public string LastName { get; set; }
      
      public string StreetAddress { get; set; }
      
      public string Email { get; set; }
      
      public string PhoneNumber { get; set; }
      
      public string City { get; set; }
      
      public string State { get; set; }
      
      public string ZipCode { get; set; }
   }
}