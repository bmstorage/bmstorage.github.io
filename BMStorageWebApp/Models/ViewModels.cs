using Microsoft.AspNetCore.Mvc.Rendering;
using BMStorage.Models;
using System.Collections.Generic;

namespace BMStorage.Models
{
    public class ViewModels
    {
      public class MusicStoreViewModel{

        public IEnumerable<BMStorage.Models.Contract> allContracts{get;set;}
        public IEnumerable<BMStorage.Models.Unit> allUnits{get;set;}
        public IEnumerable<BMStorage.Models.UnitType> allUnitTypes{get;set;}
        public IEnumerable<BMStorage.Models.User> allUsers{get;set;}
        
        public IEnumerable<BMStorage.Models.UserType> allUserTypes{get;set;}
}

    }
}