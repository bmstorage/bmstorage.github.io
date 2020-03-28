using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class Contract
   {
      [Display(Name = "Contract ID")]
      public int ContractID { get; set; }

      public int UnitID { get; set; }

      public int UserID { get; set; }

      public DateTime StartDate { get; set; }

      public DateTime? EndDate { get; set; }
      public static readonly DateTime END_OF_TIME = new DateTime(3000, 01, 01);

      /* Nagivation Properties */

      /* https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key */
      // Link to Microsoft Docs for double Navigation Property Helps
      public Unit Unit { get; set; }

      [Display(Name = "Tenant")]
      public User User { get; set; }



   }
}