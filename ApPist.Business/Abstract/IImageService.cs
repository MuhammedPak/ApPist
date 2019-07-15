using ApPist.Domain.Common;
using ApPist.Domain.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Business.Abstract
{
    public interface IImageService : IBaseService
    {
        void AddImage(Image image);
        void DeleteImage(Image image);
        void UpdateImage(Image image);
        Image GetImage(int id);
        List<Image> GetAllImage();
        void UploadFile(IFormFile formFile);
    }
}
