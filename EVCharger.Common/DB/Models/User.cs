using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EVCharger.Base.Models.Enums;
// ReSharper disable NonReadonlyMemberInGetHashCode

namespace EVCharger.Base.Models.Models
{
   public class User
   {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public string Id { get; set; }
      public string Name { get; set; }
      
      public string Password { get; set; }
      
      public double Balance { get; set; }
      
      public AccountType AccountType { get; set; }
      
      public virtual ICollection<Constellation> Constellations { get; set; }

      public override bool Equals(object obj)
      {
         if (!(obj is User user))
            return false;
      
         return user.Id == Id;
      }
      
      public override int GetHashCode()
      {
         unchecked
         {
            var hashCode = (Id != null ? Id.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (Password != null ? Password.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ Balance.GetHashCode();
            hashCode = (hashCode * 397) ^ (int) AccountType;
            hashCode = (hashCode * 397) ^ (Constellations != null ? Constellations.GetHashCode() : 0);
            return hashCode;
         }
      }
   }
}