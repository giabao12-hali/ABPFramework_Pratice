using Hali.Product.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Hali.Product.Blazor.Pages
{
    public partial class Products
    {
        private readonly ICategoryAppService _categoryAppService;
        private readonly IProductAppService _productAppService;

        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public List<ProductDto> ProductsDto { get; set; } = new List<ProductDto>();
        public CategoryDto SelectedCategory { get; set; } = new CategoryDto();

        public Products(ICategoryAppService categoryAppService, IProductAppService productAppService)
        {
            _categoryAppService = categoryAppService;
            _productAppService = productAppService;
        }
        protected override async Task OnInitializedAsync()
        {
            Categories = await GetCategoriesAsync();
            Entities = await GetProductsAsync();

            //SelectedCategoryId = CurrentProduct.CategoryId;
        }

        private async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var categoryPagedResult = await _categoryAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            return categoryPagedResult.Items.ToList();
        }
        private async Task<List<ProductDto>> GetProductsAsync()
        {
            var productPagedResult = await _productAppService.GetListAsync(new PagedAndSortedResultRequestDto());
            return productPagedResult.Items.ToList();
        }

        private async Task CreateProductAsync()
        {
            var createProductDto = new CreateUpdateProductDto
            {
                Name = NewEntity.Name,
                PublishDate = NewEntity.PublishDate,
                Price = NewEntity.Price,
                CategoryId = SelectedCategory.Id
            };

            var createdProduct = await _productAppService.CreateAsync(createProductDto);

            if (createdProduct != null)
            {
                ProductsDto.Add(createdProduct);
                ProductsDto = await GetProductsAsync();
            }

            await CloseCreateModalAsync();
        }
    }
}
