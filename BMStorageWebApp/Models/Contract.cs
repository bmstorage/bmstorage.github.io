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

        public int TenantID { get; set; }

        public int EmployeeID { get; set; }

      public DateTime StartDate { get; set; }

      public DateTime EndDate { get; set; }

      /* Nagivation Properties */

      /* https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key */
      // Link to Microsoft Docs for double Navigation Property Helps
      public Unit Unit { get; set; }
      //public User Tenant { get; set; }
      //public User Employee { get; set; }

        public User Tenant { get; set; }

        public User Employee { get; set; }

    }
}