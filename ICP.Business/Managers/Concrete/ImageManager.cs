using ICP.Business.Managers.Abstract;
using ICP.Core.DataAccess.MongoAccess.Abstract;
using ICP.Models.Collections;
using System.Collections.Generic;

namespace ICP.Business.Managers.Concrete
{
    public class ImageManager : IImageService
    {
        IMongoRepository<t_image> _imageRepo;
        public ImageManager(IMongoRepository<t_image> imageRepo)
        {
            _imageRepo = imageRepo;
        }

        public void AddImage(List<t_image> Images)
        {
            _imageRepo.InsertMany(Images);
        }
    }
}
