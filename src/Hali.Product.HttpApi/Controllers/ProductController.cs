using Hali.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Hali.Product.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductController : AbpControllerBase
{
    protected ProductController()
    {
        LocalizationResource = typeof(ProductResource);
    }
}
