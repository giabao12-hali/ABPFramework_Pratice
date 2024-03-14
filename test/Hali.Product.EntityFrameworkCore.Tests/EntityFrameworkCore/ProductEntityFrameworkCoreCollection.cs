using Xunit;

namespace Hali.Product.EntityFrameworkCore;

[CollectionDefinition(ProductTestConsts.CollectionDefinitionName)]
public class ProductEntityFrameworkCoreCollection : ICollectionFixture<ProductEntityFrameworkCoreFixture>
{

}
