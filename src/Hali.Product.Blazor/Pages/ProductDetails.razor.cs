using AutoMapper;
using Hali.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Hali.Product.Blazor.Pages
{
    public partial class ProductDetails
    {
        private ProductDto ProductDto{ get; set; } = new ProductDto();
        private List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

        private readonly ICategoryAppService _categoryAppService;
        private readonly IProductAppService _productAppService;

        public ProductDetails(ICategoryAppService categoryAppService, IProductAppService productAppService)
        {
            _categoryAppService = categoryAppService;
            _productAppService = productAppService;
        }

        protected override async Task OnInitializedAsync()
        {
            Categories = await GetCategoriesAsync();
            ProductDto = await GetProductAsync(Id);
        }

        private async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var categoryPagedResult = await _categoryAppService.GetListAsync(new PagedAndSortedResultRequestDto());
            return categoryPagedResult.Items.ToList();
        }

        private async Task<ProductDto> GetProductAsync(Guid id)
        {
            return await _productAppService.GetAsync(id);
        }

        protected async Task UpdateProductAsync(ProductDto productDto)
        {
            CreateUpdateProductDto productUpdate = new CreateUpdateProductDto
            {
                Id = productDto.Id,
                Name = productDto.Name,
                PublishDate = productDto.PublishDate,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId
            };
            await _productAppService.UpdateAsync(productDto.Id, productUpdate);
            NavigationManager.NavigateTo("/products");
        }

        //private async Task<ProductDto> UpdateProductAsync(ProductDto productDto)
        //{
        //    CreateUpdateProductDto productUpdate = new CreateUpdateProductDto
        //    {
        //        Id = productDto.Id,
        //        Name = productDto.Name,
        //        PublishDate = productDto.PublishDate,
        //        Price = productDto.Price,
        //        CategoryId = productDto.CategoryId
        //    };
        //    return await _productAppService.UpdateAsync(productDto.Id, productUpdate);
        //}

        //private readonly IProductAppService _productAppService;
        //private readonly ICategoryAppService _categoryAppService;

        //public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        //public ProductDto CurrentProduct { get; set; } = new ProductDto();
        //public CategoryDto SelectedCategory { get; set; } = new CategoryDto();

        //public ProductDetails(IProductAppService productAppService, ICategoryAppService categoryAppService)
        //{
        //    _productAppService = productAppService;
        //    _categoryAppService = categoryAppService;
        //}

        //protected override async Task OnInitializedAsync()
        //{
        //    Categories = await GetCategoriesAsync();
        //    CurrentProduct = await GetProductAsync();
        //}

        //private async Task<List<CategoryDto>> GetCategoriesAsync()
        //{
        //    var categoryPagedResult = await _categoryAppService.GetListAsync(new PagedAndSortedResultRequestDto());

        //    return categoryPagedResult.Items.ToList();
        //}

        //private async Task<ProductDto> GetProductAsync()
        //{
        //    return await _productAppService.GetAsync(CurrentProduct.Id);
        //}
    }
}
