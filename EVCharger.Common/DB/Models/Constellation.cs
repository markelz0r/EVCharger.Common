using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVCharger.Base.Models.Models
{
   public class Constellation
   {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public string Id { get; set; }
      public string Name { get; set; }
      public virtual ICollection<User> Users { get; set; }
      
      public virtual ICollection<Charger> Chargers { get; set; }
   }
}