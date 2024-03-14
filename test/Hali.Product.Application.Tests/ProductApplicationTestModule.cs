using Volo.Abp.Modularity;

namespace Hali.Product;

[DependsOn(
    typeof(ProductApplicationModule),
    typeof(ProductDomainTestModule)
)]
public class ProductApplicationTestModule : AbpModule
{

}
