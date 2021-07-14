using ICP.Models.DTO.ImageDto;
using System.Collections.Generic;

namespace ICP.Business.Helpers.CloudinaryHelper.Abstract
{
    public interface IImageHelper
    {
        List<AddImageDto> AddPhoto(List<AddImageDto> Images);
    }
}
