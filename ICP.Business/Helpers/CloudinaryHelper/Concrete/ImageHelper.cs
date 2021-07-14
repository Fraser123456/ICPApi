using ICP.Models.DTO.ImageDto;
using System.Collections.Generic;
using ICP.Business.Helpers.CloudinaryHelper.Abstract;
using Microsoft.Extensions.Options;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace ICP.Business.Helpers.CloudinaryHelper.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private readonly IOptions<CloudinarySettings> _cloudinaryConfi;
        private readonly Cloudinary _cloudinary;
        public ImageHelper(IOptions<CloudinarySettings> cloudinaryConfi)
        {
            _cloudinaryConfi = cloudinaryConfi;

            Account acc = new Account(
                _cloudinaryConfi.Value.CloudName,
                _cloudinaryConfi.Value.ApiKey,
                _cloudinaryConfi.Value.ApiSecret
            );

            _cloudinary = new Cloudinary(acc);
        }

        public List<AddImageDto> AddPhoto(List<AddImageDto> Images)
        {
            var uploadResult = new ImageUploadResult();

            foreach(AddImageDto image in Images)
            {
                var file = image.File;

                if(file.Length > 0)
                {
                    using (var stream = file.OpenReadStream())
                    {
                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription(file.Name, stream),
                            Transformation = new Transformation().Width(500).Height(500).Crop("fill").Gravity("face")
                        };

                        uploadResult = _cloudinary.Upload(uploadParams);

                        image.Url = uploadResult.Url.ToString();
                        image.PublicId = uploadResult.PublicId;
                    }
                }
            }

            return Images;
        }

    }
}
