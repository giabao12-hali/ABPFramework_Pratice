using System.Threading.Tasks;

namespace Hali.Product.Data;

public interface IProductDbSchemaMigrator
{
    Task MigrateAsync();
}
