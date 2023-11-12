#region Usings

using GeoIpFallback.Providers;
using Sitecore.Configuration;

#endregion

namespace GeoIpFallback.Providers
{
    public static class LocationFallbackManager
    {
        private static readonly ProviderHelper<LocationFallbackProviderBase, LocationFallbackProviderCollection> ProviderHelper =
            new ProviderHelper<LocationFallbackProviderBase, LocationFallbackProviderCollection>("locationFallbackManager");

        static LocationFallbackManager()
        {
        }

        public static LocationFallbackProviderBase LocationFallbackProvider => ProviderHelper.Provider;
    }
}