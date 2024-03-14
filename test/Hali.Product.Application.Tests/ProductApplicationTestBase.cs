using Volo.Abp.Modularity;

namespace Hali.Product;

public abstract class ProductApplicationTestBase<TStartupModule> : ProductTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
