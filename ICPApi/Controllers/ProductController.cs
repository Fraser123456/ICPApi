using ICP.Business.Managers.Abstract;
using ICP.Models.Collections;
using ICP.Models.DTO.ProductDto;
using ICP.Models.Models.Product;
using ICPApi.Filters;
using ICPApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ICPApi.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("api/AddProduct")]
        [HttpPost]
        [ExceptionHandler]
        public BaseResponseServiceModel AddProduct(AddProductViewModel Product)
        {
            t_product Result = _productService.AddProduct(new AddProductDto { 
                name = Product.Title,
                description = Product.Description,
                Images = Product.Images
            });

            return new BaseResponseServiceModel
            {
                Type = "S",
                ResponseModel = Result
            };
        }
    }
}
