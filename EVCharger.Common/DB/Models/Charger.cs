using System.ComponentModel.DataAnnotations.Schema;

namespace EVCharger.Common.Protobuf.DB.Models
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