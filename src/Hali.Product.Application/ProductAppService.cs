using System;
using System.Collections.Generic;
using System.Text;
using Hali.Product.Localization;
using Volo.Abp.Application.Services;

namespace Hali.Product;

/* Inherit your application services from this class.
 */
public abstract class ProductAppService : ApplicationService
{
    protected ProductAppService()
    {
        LocalizationResource = typeof(ProductResource);
    }
}
