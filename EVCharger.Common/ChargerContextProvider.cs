using EVCharger.Authentication.Interfaces;
using EVCharger.Common.Protobuf.DB;

namespace EVCharger.Common.Protobuf
{
   /// <summary>
   /// This wrapper class allows us to instantiate DB context
   /// Makes the code using it more unit-testable
   /// </summary>
   public class ChargerContextProvider : IChargerContextProvider
   {
      public ChargerContext Context => new();
   }
}