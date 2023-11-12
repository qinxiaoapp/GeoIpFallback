#region Usings

using Sitecore.Configuration;

#endregion

namespace GeoIpFallback.Mock
{
    public static class MockLocationFallbackManager
    {
        private static readonly ProviderHelper<MockLocationFallbackProviderBase, MockLocationFallbackProviderCollection> ProviderHelper =
            new ProviderHelper<MockLocationFallbackProviderBase, MockLocationFallbackProviderCollection>("mockLocationFallbackManager");

        static MockLocationFallbackManager()
        {
        }

        public static MockLocationFallbackProviderBase MockLocationFallbackProvider => ProviderHelper.Provider;
    }
}