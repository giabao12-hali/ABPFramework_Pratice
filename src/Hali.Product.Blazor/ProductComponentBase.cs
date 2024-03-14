using Hali.Product.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Hali.Product.Blazor;

public abstract class ProductComponentBase : AbpComponentBase
{
    protected ProductComponentBase()
    {
        LocalizationResource = typeof(ProductResource);
    }
}
