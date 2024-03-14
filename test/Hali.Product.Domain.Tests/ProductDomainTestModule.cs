using Volo.Abp.Modularity;

namespace Hali.Product;

[DependsOn(
    typeof(ProductDomainModule),
    typeof(ProductTestBaseModule)
)]
public class ProductDomainTestModule : AbpModule
{

}
