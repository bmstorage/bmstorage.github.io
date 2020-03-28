using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class UnitType
   {
      [Display(Name = "Unit Type ID")]
      public int UnitTypeID { get; set; }

      [Display(Name = "Unit Type Name")]
      public string UnitTypeName { get; set; }

      // Feet Wide
      [Column(TypeName = "decimal(6,2)")]
      public decimal Width { get; set; }

      // Feet Deep
      [Column(TypeName = "decimal(6,2)")]
      public decimal Depth { get; set; }

      // Feet Tall
      [Column(TypeName = "decimal(6,2)")]
      public decimal Height { get; set; }

      [Column(TypeName = "decimal(6,2)")]
      public decimal Price { get; set; }


   }
}