using System;
using System.Collections.Generic;

namespace EVCharger.Common.Protobuf.DB.Models
{
   public class ChargingSession
   {
      public string Id { get; set; }
      
      public DateTime StartTime { get; set; }
      
      public DateTime EndTime { get; set; }
      
      public virtual Charger Charger { get; set; }

      public virtual User User { get; set; }

      public List<double> EnergyUsed { get; set; }
      
      public double Tariff { get; set; }
   }
}