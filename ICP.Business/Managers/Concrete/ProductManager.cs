using ICP.API.Managers.Helpers;
using ICP.Business.Helpers.CloudinaryHelper.Abstract;
using ICP.Business.Managers.Abstract;
using ICP.Core.DataAccess.MongoAccess.Abstract;
using ICP.Models.Collections;
using ICP.Models.DTO.ImageDto;
using ICP.Models.DTO.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ICP.Business.Managers.Concrete
{
    public class ProductManager : IProductService
    {
        IMongoRepository<t_product> _productRepo;
        private IImageHelper _imageHelper;
        private IImageService _imageService;
        public ProductManager(IMongoRepository<t_product> productRepo, IImageHelper imageHelper, IImageService imageService)
        {
            _productRepo = productRepo;
            _imageHelper = imageHelper;
            _imageService = imageService;
        }

        public t_product AddProduct(AddProductDto product)
        {
            CheckIfProductExists(product);

            t_product ProductToAdd = new t_product { 
                name = product.name,
                description = product.description
            };

            t_product Result = _productRepo.InsertOne(ProductToAdd);

            List<AddImageDto> AddedImages = _imageHelper.AddPhoto(product.Images);

            foreach(AddImageDto image in AddedImages)
            {
                Result.images.Add(new t_image
                {
                    t_product_id = Result._id,
                    url = image.Url,
                    public_id = image.PublicId
                });
            }

            List<t_image> ImagesToAdd = Result.images.ToList();

            _imageService.AddImage(ImagesToAdd);

            return Result;
        }

        private void CheckIfProductExists(AddProductDto product)
        {
            t_product Result = _productRepo.FindOne(x => x.name == product.name);

            if (Result != null)
                throw new CoreException("Product already exists");
        }
    }
}
