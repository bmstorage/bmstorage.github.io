using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class UnitType
   {
      [Display(Name = "Unit Type ID")]
      public int UnitTypeID { get; set; }
      
      public string UnitTypeName { get; set; }
      
      public decimal Width { get; set; }
      
      public decimal Depth { get; set; }
      
      public decimal Height { get; set; }
      
      public decimal Price { get; set; }
      
   }
}