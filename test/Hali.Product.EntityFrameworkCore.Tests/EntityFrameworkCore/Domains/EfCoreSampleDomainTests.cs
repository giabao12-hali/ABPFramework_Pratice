using Hali.Product.Samples;
using Xunit;

namespace Hali.Product.EntityFrameworkCore.Domains;

[Collection(ProductTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProductEntityFrameworkCoreTestModule>
{

}
