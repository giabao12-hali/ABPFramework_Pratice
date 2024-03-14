using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Hali.Product;

[Dependency(ReplaceServices = true)]
public class ProductBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Product";
}
