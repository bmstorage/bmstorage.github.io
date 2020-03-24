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
      
      public int TenantAccountID { get; set; }
      
      public int EmployeeAccountID { get; set; }
      
      public DateTime StartDate { get; set; }
      
      public DateTime EndDate { get; set; }
   }
}