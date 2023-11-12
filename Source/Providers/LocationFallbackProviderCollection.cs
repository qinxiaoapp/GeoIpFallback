#region Usings

using System.Configuration.Provider;
using GeoIpFallback.Providers;
using Sitecore.Diagnostics;

#endregion

namespace GeoIpFallback.Providers
{
    public class LocationFallbackProviderCollection : ProviderCollection
    {
        public virtual LocationFallbackProviderBase this[string name]
        {
            get
            {
                Assert.ArgumentNotNull(name, nameof(name));
                return base[name] as LocationFallbackProviderBase;
            }
        }

        public override void Add(ProviderBase provider)
        {
            Assert.ArgumentNotNull(provider, nameof(provider));
            LocationFallbackProviderBase provider1 = provider as LocationFallbackProviderBase;
            Assert.IsNotNull(provider1,
                "The provider type passed to LocationProviderCollection is not assignable to LocationProviderBase. Actual type: {0}",
                (object)provider.GetType().FullName);
            Add(provider1);
        }

        public virtual void Add(LocationFallbackProviderBase provider)
        {
            Assert.ArgumentNotNull(provider, nameof(provider));
            base.Add(provider);
        }
    }
}