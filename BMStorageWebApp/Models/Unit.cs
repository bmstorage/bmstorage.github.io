using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMStorage.Models
{
   public class Unit
   {
      [Display(Name = "Unit ID")]
      public int UnitID { get; set; }

      public int UnitTypeID { get; set; }

      public string UnitLocation { get; set; }

   }
}