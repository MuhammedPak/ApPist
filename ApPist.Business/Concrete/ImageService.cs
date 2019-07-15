using ApPist.Business.Abstract;
using ApPist.DataAccess.Abstract;
using ApPist.Domain.Common;
using ApPist.Domain.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;

namespace ApPist.Business.Concrete
{
    public class ImageService : BaseService, IImageService
    {
        private readonly IEntityRepository<Image> db;
        private readonly IHostingEnvironment hostingEnvironment;

        public ImageService(IEntityRepository<Image> _entityRepository, IHostingEnvironment _hostingEnvironment)
        {
            db = _entityRepository;
            hostingEnvironment = _hostingEnvironment;
        }

        public void AddImage(Image image)
        {
            db.Add(image);
        }

        public void DeleteImage(Image image)
        {
            db.Delete(image);
        }

        public List<Image> GetAllImage()
        {
            var model = db.GetAll();

            return model;
        }

        public Image GetImage(int id)
        {
            return null;
        }

        public void UpdateImage(Image image)
        {
            db.Update(image);
        }

        public void UploadFile(IFormFile file)
        {

            if (file.Length > 0)
            {
                string fileName = file.FileName;
                //2 Get the extension of the file
                string extension = Path.GetExtension(fileName);


                string filePath = string.Concat(hostingEnvironment.WebRootPath, "\\Images");

                //5 copy the file to the path
                using (var fileStream = new FileStream(
                    Path.Combine(filePath, fileName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                var image = new Image
                {
                    Path = fileName
                };

                AddImage(image);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
