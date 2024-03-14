using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Hali.Product
{
    public class ProductStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product.Models.Product, Guid> _productRepository;
        private readonly IRepository<Product.Models.Category, Guid> _categoryRepository;
        public ProductStoreDataSeederContributor(IRepository<Product.Models.Product, Guid> productRepository,
            IRepository<Models.Category, Guid> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _productRepository.GetCountAsync() < 0)
            {
                await _productRepository.InsertAsync(
                                       new Product.Models.Product
                                       {
                        Name = "Product 1",
                        Price = 100,
                        PublishDate = DateTime.Now,
                    },
                                                          autoSave: true
                                                                         );
                await _productRepository.InsertAsync(
                                       new Product.Models.Product
                                       {
                                           Name = "Product 2",
                                           Price = 100,
                                           PublishDate = DateTime.Now,
                                       },
                                                          autoSave: true
                                                                         );
            }

            if (await _categoryRepository.GetCountAsync() < 0)
            {
                await _categoryRepository.InsertAsync(
                 new Product.Models.Category
                 {
                  Name = "Category 1",
                 },
                 autoSave: true
                 );
                await _categoryRepository.InsertAsync(
                new Product.Models.Category
                {
                    Name = "Category 2",
                },
                autoSave: true
                );
            }
        //    var seedData = new[]
        //{
        //    new { CategoryName = "Category 1", ProductName = "Product 1", Price = 100 },
        //    new { CategoryName = "Category 2", ProductName = "Product 2", Price = 200 },
        //};

        //    foreach (var data in seedData)
        //    {
        //        // kiểm tra giá trị có tồn tại trong db chưa, nếu chưa thì thêm mới
        //        var category = await _categoryRepository.FirstOrDefaultAsync(c => c.Name == data.CategoryName)
        //                        ?? await _categoryRepository.InsertAsync(new Product.Models.Category { Name = data.CategoryName }, autoSave: true);

        //        await _productRepository.InsertAsync(
        //            new Product.Models.Product
        //            {
        //                Name = data.ProductName,
        //                Price = data.Price,
        //                PublishDate = DateTime.Now,
        //                CategoryId = category.Id
        //            },
        //            autoSave: true
        //        );
        //    }
        }
    }
}
