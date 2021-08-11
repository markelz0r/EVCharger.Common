using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EVCharger.Common.Protobuf.DB.Enums;

namespace EVCharger.Common.Protobuf.DB.Models
{
   public class Constellation
   {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public string Id { get; set; }
      public string Name { get; set; }
      public virtual ICollection<User> Users { get; set; }
      public virtual ICollection<Charger> Chargers { get; set; }
      
      public OperationMode OperationMode { get; set; }
      public double MinBalanceToInitiateCharging { get; set; } = 51;
      public bool OverdraftIstAllowed { get; set; } = true;
      public double DefaultTariff { get; set; } = 4.5;
   }
}