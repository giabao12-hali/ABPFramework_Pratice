using Hali.Product.Samples;
using Xunit;

namespace Hali.Product.EntityFrameworkCore.Applications;

[Collection(ProductTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProductEntityFrameworkCoreTestModule>
{

}
