using ICP.Models.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICP.Business.Managers.Abstract
{
    public interface IImageService 
    {
        void AddImage(List<t_image> Images);
    }
}
