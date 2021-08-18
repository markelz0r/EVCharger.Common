using EVCharger.Common.Protobuf.DB;

namespace EVCharger.Authentication.Interfaces
{
   public interface IChargerContextProvider
   {
      ChargerContext Context { get; }
   }
}