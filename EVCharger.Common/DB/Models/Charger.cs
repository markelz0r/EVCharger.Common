using System.ComponentModel.DataAnnotations.Schema;
using EVCharger.Common.Protobuf;

namespace EVCharger.Base.Models.Models
{
   public class Charger
   {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public string Id { get; set; }
      public string Name { get; set; }
      public ChargerStatus ChargerStatus { get; set; }
      public virtual Constellation Constellation { get; set; }
   }
}