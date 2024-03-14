using Volo.Abp.Modularity;

namespace Hali.Product;

/* Inherit from this class for your domain layer tests. */
public abstract class ProductDomainTestBase<TStartupModule> : ProductTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
